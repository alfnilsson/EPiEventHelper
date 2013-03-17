using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IFinishedLoadingPage
    {
        void FinishedLoadingPage(object sender, PageEventArgs e);
    }
}