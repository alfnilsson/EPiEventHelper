using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedContent
    {
        void DeletedContent(object sender, DeleteContentEventArgs e);
    }
}