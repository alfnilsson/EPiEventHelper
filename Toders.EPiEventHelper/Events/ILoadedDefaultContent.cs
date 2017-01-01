using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedDefaultContent
    {
        void LoadedDefaultContent(object sender, ContentEventArgs e);
    }
}