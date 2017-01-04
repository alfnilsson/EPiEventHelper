using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingContent
    {
        void LoadingContent(object sender, ContentEventArgs e);
    }
}