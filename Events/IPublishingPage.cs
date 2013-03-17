using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishingPage
    {
        void PublishingPage(object sender, PageEventArgs e);
    }
}