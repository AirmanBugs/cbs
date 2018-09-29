/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Collections.Generic;
using Infrastructure.Read;
using Infrastructure.Read.MongoDb;
using MongoDB.Driver;

namespace Read.AutomaticReplyMessages
{
    public class ReplyMessages : ExtendedReadModelRepositoryFor<ReplyMessagesConfig>,
        IReplyMessages
    {

        public ReplyMessages(IMongoDatabase database)
            : base(database)
        {
        }
        
    }
}