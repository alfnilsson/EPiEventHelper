using System;
using System.Linq;
using EPiServer.ServiceLocation;

namespace Toders.EPiEventHelper.EventHandlers
{
    public interface IEventRunner
    {
        void Run<TEvent>(Action<TEvent> action);
    }

    [ServiceConfiguration(typeof(IEventRunner))]
    public class EventRunner : IEventRunner
    {
        private readonly IServiceLocator _serviceLocator;

        public EventRunner(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public void Run<TEvent>(Action<TEvent> action)
        {
            var events = _serviceLocator
                .GetAllInstances<TEvent>()
                .ToArray();

            foreach (var e in events)
            {
                action(e);
            }
        }
    }
}