using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Toders.EPiEventHelper
{
    [InitializableModule]
    public class EventInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            EventBinder.BindEvents();
        }

        public void Preload(string[] parameters) { }

        public void Uninitialize(InitializationEngine context)
        {
            EventBinder.UnbindEvents();
        }
    }
}