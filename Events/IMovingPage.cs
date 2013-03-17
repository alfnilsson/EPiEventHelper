using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovingPage
    {
        void MovingPage(object sender, PageEventArgs e);
    }
}