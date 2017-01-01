using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IRejectedContent
    {
        void RejectedContent(object sender, ContentEventArgs args);
    }
}