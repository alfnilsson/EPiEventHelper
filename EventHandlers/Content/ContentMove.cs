using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentMove
    {
        public static void MovingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IMovingContent>(e => e.MovingContent(sender, eventArgs));
        }

        public static void MovedContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IMovedContent>(e => e.MovedContent(sender, eventArgs));
        }
    }
}