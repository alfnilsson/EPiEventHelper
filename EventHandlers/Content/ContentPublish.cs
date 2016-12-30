using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentPublish
    {
        public static void PublishingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IPublishingContent>(e => e.PublishingContent(sender, eventArgs));
        }

        public static void PublishedContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IPublishedContent>(e => e.PublishedContent(sender, eventArgs));
        }
    }
}