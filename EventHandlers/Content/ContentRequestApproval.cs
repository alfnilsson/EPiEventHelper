using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentRequestApproval
    {
        public static void RequestingApproval(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IRequestingApproval>(e => e.RequestingApproval(sender, args));
        }

        public static void RequestedApproval(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IRequestedApproval>(e => e.RequestedApproval(sender, args));
        }
    }
}