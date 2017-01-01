using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckingOutContent
    {
        void CheckingOutContent(object sender, ContentEventArgs args);
    }
}