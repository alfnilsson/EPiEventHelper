using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentCreate
    {
        public static void CreatingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICreatingContent>(e => e.CreatingContent(sender, eventArgs));
        }

        public static void CreatedContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICreatedContent>(e => e.CreatedContent(sender, eventArgs));
        }
    }
}