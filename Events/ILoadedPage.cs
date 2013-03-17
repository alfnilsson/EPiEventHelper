using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedPage
    {
        void LoadedPage(object sender, PageEventArgs e);
    }
}