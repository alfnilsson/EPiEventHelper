using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ISchedulingContent
    {
        void SchedulingContent(object sender, ContentEventArgs args);
    }
}