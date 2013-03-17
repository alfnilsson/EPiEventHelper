using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedContentVersion
    {
        void DeletedContentVersion(object sender, ContentEventArgs e);
    }
}