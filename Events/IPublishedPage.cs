using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishedPage
    {
        void PublishedPage(object sender, PageEventArgs e);
    }
}