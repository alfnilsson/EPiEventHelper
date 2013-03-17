using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavedPage
    {
        void SavedPage(object sender, PageEventArgs e);
    }
}