using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckingInContent
    {
        void CheckingInContent(object sender, ContentEventArgs e);
    }
}