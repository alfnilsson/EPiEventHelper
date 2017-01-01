using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentReject
    {
        public static void RejectingContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IRejectingContent>(e => e.RejectingContent(sender, args));
        }

        public static void RejectedContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IRejectedContent>(e => e.RejectedContent(sender, args));
        }
    }
}