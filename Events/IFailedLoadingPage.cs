using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IFailedLoadingPage
    {
        void FailedLoadingPage(object sender, PageEventArgs e);
    }
}