using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedContent
    {
        void LoadedContent(object sender, ContentEventArgs e);
    }
}