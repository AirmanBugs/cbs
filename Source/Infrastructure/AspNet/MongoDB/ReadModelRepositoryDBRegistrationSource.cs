/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Lifetime;
using Autofac.Core.Registration;
using Dolittle.ReadModels.MongoDB;
using Infrastructure.AspNet.ConnectionStrings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.AspNet.MongoDB
{
    public class ReadModelRepositoryDBRegistrationSource : IRegistrationSource
    {
        public bool IsAdapterForIndividualComponents => false;

        public IEnumerable<IComponentRegistration> RegistrationsFor(Service service,
            Func<Service, IEnumerable<IComponentRegistration>> registrationAccessor)
        {
            var serviceWithType = service as IServiceWithType;

            if (serviceWithType == null || serviceWithType.ServiceType != typeof(Dolittle.ReadModels.MongoDB.ReadModelRepositoryConfiguration))
                return Enumerable.Empty<IComponentRegistration>();

            var registration = new ComponentRegistration(
                Guid.NewGuid(),
                new DelegateActivator(serviceWithType.ServiceType, (c, p) =>
                {
                    var connectionStrings = c.Resolve<IOptions<ConnectionStringsOptions>>().Value;
                    var connectionString =
                        connectionStrings.ConnectionStrings.SingleOrDefault(t =>
                            t.Type == ConnectionStringType.MongoDB);
                    if (connectionString == null)
                        throw new MissingConnectionStringForDatabaseType(ConnectionStringType.MongoDB);

                    var configuration = new Dolittle.ReadModels.MongoDB.ReadModelRepositoryConfiguration
                    {
                        ConnectionString = connectionString.Value,
                        UseSSL = false,
                        Database = connectionString.Database
                    };
                    return configuration;
                }),
                new CurrentScopeLifetime(),
                InstanceSharing.Shared,
                InstanceOwnership.OwnedByLifetimeScope,
                new[] {service},
                new Dictionary<string, object>()
            );

            return new[] {registration};
        }
    }
}