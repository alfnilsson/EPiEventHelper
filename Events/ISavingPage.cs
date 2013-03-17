using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavingPage
    {
        void SavingPage(object sender, PageEventArgs e);
    }
}