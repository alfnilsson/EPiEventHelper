using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentLoad
    {
        private readonly IEventRunner _eventRunner;

        public ContentLoad(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;

        }

        public void LoadingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadingContent>(e => e.LoadingContent(sender, args));
        }

        public void LoadedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadedContent>(e => e.LoadedContent(sender, args));
        }

        public void FailedLoadingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IFailedLoadingContent>(e => e.FailedLoadingContent(sender, args));
        }
    }
}