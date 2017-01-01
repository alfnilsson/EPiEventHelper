using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentMove
    {
        public static void MovingContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IMovingContent>(e => e.MovingContent(sender, args));
        }

        public static void MovedContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IMovedContent>(e => e.MovedContent(sender, args));
        }
    }
}