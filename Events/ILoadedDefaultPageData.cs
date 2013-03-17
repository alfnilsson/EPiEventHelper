using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedDefaultPageData
    {
        void LoadedDefaultPageData(object sender, PageEventArgs e);
    }
}