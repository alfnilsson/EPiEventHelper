using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovedPage
    {
        void MovedPage(object sender, PageEventArgs e);
    }
}