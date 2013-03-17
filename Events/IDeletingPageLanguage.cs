using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingPageLanguage
    {
        void DeletingPageLanguage(object sender, PageEventArgs e);
    }
}