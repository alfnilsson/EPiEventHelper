using System;
using System.Linq;
using EPiServer.ServiceLocation;

namespace Toders.EPiEventHelper.EventHandlers
{
    public static class Runner
    {
        public static void Run<TEvent>(Action<TEvent> action)
        {
            var events = ServiceLocator.Current
                .GetAllInstances<TEvent>()
                .ToArray();

            foreach (var e in events)
            {
                action(e);
            }
        }
    }
}