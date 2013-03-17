using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedPageLanguage
    {
        void DeletedPageLanguage(object sender, PageEventArgs e);
    }
}