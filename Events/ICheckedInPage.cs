using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckedInPage
    {
        void CheckedInPage(object sender, PageEventArgs e);
    }
}