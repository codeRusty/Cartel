using Cartel.Common.Commands;
using Cartel.Common.Events;
using Cartel.Common.RabbitMq;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace Cartel.Common.Services
{
    public class BusBuilder : BuilderBase
    {
        private IWebHost _webHost;
        private IBusClient _bus;

        public BusBuilder(IWebHost webHost, IBusClient bus)
        {
            _webHost = webHost;
            _bus = bus;
        }

        public override ServiceHost Build()
        {
            return new ServiceHost(_webHost);
        }

        public BusBuilder SubscribeToCommand<TCommand>() where TCommand : ICommand
        {
            var handler = (ICommandHandler<TCommand>)_webHost.Services
                .GetService(typeof(ICommandHandler<TCommand>));

             _bus.WithCommandHandlerAsync(handler);
            return this;
        }

        public BusBuilder SubscribeToEvent<TEvent>() where TEvent : IEvent
        {
            var handler = (IEventHandler<IEvent>)_webHost.Services
                .GetService(typeof(IEventHandler<IEvent>));
            _bus.WithEventHandlerAsync(handler);
            return this;
        }

    }
}