using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContent
    {
        void DeletingContent(object sender, DeleteContentEventArgs e);
    }
}