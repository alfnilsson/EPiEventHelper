using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentCheckOut
    {
        public static void CheckingOutContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICheckingOutContent>(e => e.CheckingOutContent(sender, eventArgs));
        }

        public static void CheckedOutContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICheckedOutContent>(e => e.CheckedOutContent(sender, eventArgs));
        }
    }
}