using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IFailedLoadingContent
    {
        void FailedLoadingContent(object sender, ContentEventArgs e);
    }
}