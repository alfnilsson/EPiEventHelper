using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishingContent
    {
        void PublishingContent(object sender, ContentEventArgs e);
    }
}