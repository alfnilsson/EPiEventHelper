using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentReject
    {
        public static void RejectingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IRejectingContent>(e => e.RejectingContent(sender, eventArgs));
        }

        public static void RejectedContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IRejectedContent>(e => e.RejectedContent(sender, eventArgs));
        }
    }
}