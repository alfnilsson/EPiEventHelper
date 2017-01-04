using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovedContent
    {
        void MovedContent(object sender, ContentEventArgs e);
    }
}