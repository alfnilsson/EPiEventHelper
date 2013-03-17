using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingPage
    {
        void DeletingPage(object sender, PageEventArgs e);
    }
}