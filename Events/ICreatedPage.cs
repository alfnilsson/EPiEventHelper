using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatedPage
    {
        void CreatedPage(object sender, PageEventArgs e);
    }
}