using Cartel.Common.Commands;
using Cartel.Common.Events;
using RawRabbit;
using System;
using System.Threading.Tasks;

namespace Cartel.Services.Activities.Handlers
{

    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _busClient;

        public CreateActivityHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }
        public async Task HandleAsync(CreateActivity command)
        {
            Console.WriteLine($"Creating Activity: {command.Name }");
            await _busClient.PublishAsync(new ActivityCreated(command.Id, command.UserID, command.Category,
                command.Name, command.Description));
        }
    }
}
