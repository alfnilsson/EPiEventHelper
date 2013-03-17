using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedContentLanguage
    {
        void DeletedContentLanguage(object sender, ContentEventArgs e);
    }
}