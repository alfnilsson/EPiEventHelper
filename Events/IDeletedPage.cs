using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedPage
    {
        void DeletedPage(object sender, PageEventArgs e);
    }
}