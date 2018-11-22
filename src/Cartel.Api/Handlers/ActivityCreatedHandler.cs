using Cartel.Common.Events;
using System;
using System.Threading.Tasks;

namespace Cartel.Api.Handlers
{
    public class ActivityCreatedHandler : IEventHandler<ActivityCreated>
    {
        public async Task HandleAsync(ActivityCreated @event)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Activity created: {@event.Name }");
        }
    }
}
