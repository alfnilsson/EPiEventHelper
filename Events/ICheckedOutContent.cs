using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckedOutContent
    {
        void CheckedOutContent(object sender, ContentEventArgs eventArgs);
    }
}