using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingDefaultContent
    {
        void LoadingDefaultContent(object sender, ContentEventArgs e);
    }
}