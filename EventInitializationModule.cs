using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Toders.EPiEventHelper
{
    [InitializableModule]
    public class EventInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            new EventBinder(ServiceLocator.Current.GetInstance<IContentEvents>()).BindEvents();
        }

        public void Preload(string[] parameters) { }

        public void Uninitialize(InitializationEngine context)
        {
            new EventBinder(ServiceLocator.Current.GetInstance<IContentEvents>()).UnbindEvents();
        }
    }
}