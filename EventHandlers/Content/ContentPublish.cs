using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentPublish
    {
        public static void PublishingContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IPublishingContent>(e => e.PublishingContent(sender, args));
        }

        public static void PublishedContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IPublishedContent>(e => e.PublishedContent(sender, args));
        }
    }
}