using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavedContent
    {
        void SavedContent(object sender, ContentEventArgs e);
    }
}