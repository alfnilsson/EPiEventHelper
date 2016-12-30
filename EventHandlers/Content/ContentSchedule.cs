using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentSchedule
    {
        public static void SchedulingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ISchedulingContent>(e => e.SchedulingContent(sender, eventArgs));
        }

        public static void ScheduledContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IScheduledContent>(e => e.ScheduledContent(sender, eventArgs));
        }
    }
}