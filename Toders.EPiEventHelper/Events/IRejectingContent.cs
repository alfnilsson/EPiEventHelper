using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IRejectingContent
    {
        void RejectingContent(object sender, ContentEventArgs args);
    }
}