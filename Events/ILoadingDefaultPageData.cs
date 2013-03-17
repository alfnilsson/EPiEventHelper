using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingDefaultPageData
    {
        void LoadingDefaultPageData(object sender, PageEventArgs e);
    }
}