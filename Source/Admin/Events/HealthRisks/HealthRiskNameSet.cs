/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Dolittle.Events;

namespace Events.HealthRisks
{
    public class HealthRiskNameSet : IEvent 
    {
        public HealthRiskNameSet(string name) => Name = name;

        public string Name { get; }       
    }
}