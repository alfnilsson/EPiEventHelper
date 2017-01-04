using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovingContent
    {
        void MovingContent(object sender, ContentEventArgs e);
    }
}