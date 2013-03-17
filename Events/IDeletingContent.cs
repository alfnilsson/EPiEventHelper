using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContent
    {
        void DeletingContent(object sender, DeleteContentEventArgs e);
    }
}