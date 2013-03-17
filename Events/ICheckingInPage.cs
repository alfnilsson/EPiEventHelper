using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckingInPage
    {
        void CheckingInPage(object sender, PageEventArgs e);
    }
}