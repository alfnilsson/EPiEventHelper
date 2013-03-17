using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingPage
    {
        void LoadingPage(object sender, PageEventArgs e);
    }
}