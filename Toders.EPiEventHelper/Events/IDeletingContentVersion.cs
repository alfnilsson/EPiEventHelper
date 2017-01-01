using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContentVersion
    {
        void DeletingContentVersion(object sender, ContentEventArgs e);
    }
}