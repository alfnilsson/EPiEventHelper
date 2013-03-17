using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatingPage
    {
        void CreatingPage(object sender, PageEventArgs e);
    }
}