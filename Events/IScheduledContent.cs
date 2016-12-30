using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IScheduledContent
    {
        void ScheduledContent(object sender, ContentEventArgs eventArgs);
    }
}