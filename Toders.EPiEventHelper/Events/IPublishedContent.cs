using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishedContent
    {
        void PublishedContent(object sender, ContentEventArgs e);
    }
}