using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentSchedule
    {
        private readonly IEventRunner _eventRunner;

        public ContentSchedule(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void SchedulingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ISchedulingContent>(e => e.SchedulingContent(sender, args));
        }

        public void ScheduledContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IScheduledContent>(e => e.ScheduledContent(sender, args));
        }
    }
}