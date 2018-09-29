using Concepts;
using Concepts.AutomaticReply;
using Dolittle.Domain;
using Domain;
using Events;
using Events.External;
using Infrastructure.AspNet;
using Microsoft.AspNetCore.Mvc;
using Read.AutomaticReplyMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/automaticreplies")]
    public class AutomaticRepliesController : Controller
    {
        private readonly IDefaultAutomaticReplies _defaultAutomaticReplies;
        private readonly IDefaultAutomaticReplyKeyMessages _defaultAutomaticReplyKeyMessages;
        private readonly IAutomaticReplies _automaticReplies;
        private readonly IAutomaticReplyKeyMessages _automaticReplyKeyMessages;

        public AutomaticRepliesController(
            IDefaultAutomaticReplies defaultAutomaticReplies,
            IDefaultAutomaticReplyKeyMessages defaultAutomaticReplyKeyMessages,
            IAutomaticReplies automaticReplies,
            IAutomaticReplyKeyMessages automaticReplyKeyMessages
            )
        {
            _defaultAutomaticReplies = defaultAutomaticReplies;
            _defaultAutomaticReplyKeyMessages = defaultAutomaticReplyKeyMessages;
            _automaticReplies = automaticReplies;
            _automaticReplyKeyMessages = automaticReplyKeyMessages;
        }

        [HttpGet("automaticreplytypes")]
        public IEnumerable<AutomaticReplyTypeName> GetAutomaticReplyTypes()
        {
            return Enum.GetValues(typeof(AutomaticReplyType)).Cast<AutomaticReplyType>().Select(c => new AutomaticReplyTypeName()
            {
                Id = (int)c,
                Name = c.ToString()
            });
        }

        [HttpGet("{projectId}")]
        public IEnumerable<Models.AutomaticReply> GetAutomaticRepliesForProject(Guid projectId)
        {
            var projectDefined =  _automaticReplies.GetByProject(projectId);
            var defaults = _defaultAutomaticReplies.GetAll();

            return projectDefined.Select(c => new Web.Models.AutomaticReply()
            {
                IsDefault = false,
                Language = c.Language,
                Type = c.Type,
                Message = c.Message
            })
            .Union(defaults
                .Where(c => !projectDefined.Any(p => p.Type == c.Type && p.Language == c.Language))
                .Select(c => new Web.Models.AutomaticReply()
                {
                    IsDefault = true,
                    Language = c.Language,
                    Type = c.Type,
                    Message = c.Message
                })
            );
        }

        [HttpGet("keymessages/{projectId}")]
        public IEnumerable<Web.Models.AutomaticReplyKeyMessage> GetAutomaticReplyKeyMessagesForProject(Guid projectId)
        {
            var projectDefined = _automaticReplyKeyMessages.GetByProject(projectId);
            var defaults = _defaultAutomaticReplyKeyMessages.GetAll();

            return projectDefined.Select(c => new Web.Models.AutomaticReplyKeyMessage()
            {
                HealthRiskId = c.HealthRiskId, 
                IsDefault = false,
                Language = c.Language,
                Type = c.Type,
                Message = c.Message
            })
            .Union(defaults
                .Where(c => !projectDefined.Any(p => p.Type == c.Type && p.Language == c.Language))
                .Select(c => new Web.Models.AutomaticReplyKeyMessage()
                {
                    HealthRiskId = c.HealthRiskId,
                    IsDefault = true,
                    Language = c.Language,
                    Type = c.Type,
                    Message = c.Message
                })
            );
        }
    }
}
