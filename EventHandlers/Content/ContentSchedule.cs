using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentSchedule
    {
        public static void SchedulingContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<ISchedulingContent>(e => e.SchedulingContent(sender, args));
        }

        public static void ScheduledContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IScheduledContent>(e => e.ScheduledContent(sender, args));
        }
    }
}