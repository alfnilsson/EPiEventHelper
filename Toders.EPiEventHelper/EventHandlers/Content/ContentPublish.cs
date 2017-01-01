using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentPublish
    {
        private readonly IEventRunner _eventRunner;

        public ContentPublish(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void PublishingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IPublishingContent>(e => e.PublishingContent(sender, args));
        }

        public void PublishedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IPublishedContent>(e => e.PublishedContent(sender, args));
        }
    }
}