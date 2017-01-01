using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class DefaultContentLoad
    {
        private readonly IEventRunner _eventRunner;

        public DefaultContentLoad(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void LoadingDefaultContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadingDefaultContent>(e => e.LoadingDefaultContent(sender, args));
        }

        public void LoadedDefaultContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadedDefaultContent>(e => e.LoadedDefaultContent(sender, args));
        }
    }
}