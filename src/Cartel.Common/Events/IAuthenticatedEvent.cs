using System;

namespace Cartel.Common.Events
{
    public interface IAuthenticatedEvent:IEvent
    {
         Guid UserId { get; set; }
    }      
}