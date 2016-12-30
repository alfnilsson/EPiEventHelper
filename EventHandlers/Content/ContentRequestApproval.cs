using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentRequestApproval
    {
        public static void RequestingApproval(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IRequestingApproval>(e => e.RequestingApproval(sender, eventArgs));
        }

        public static void RequestedApproval(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IRequestedApproval>(e => e.RequestedApproval(sender, eventArgs));
        }
    }
}