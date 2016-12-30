using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentCheckIn
    {
        public static void CheckingInContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICheckingInContent>(e => e.CheckingInContent(sender, eventArgs));
        }

        public static void CheckedInContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICheckedInContent>(e => e.CheckedInContent(sender, eventArgs));
        }
    }
}