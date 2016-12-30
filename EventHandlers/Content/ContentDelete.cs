using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentDelete
    {
        public static void DeletingContent(object sender, DeleteContentEventArgs eventArgs)
        {
            Runner.Run<IDeletingContent>(e => e.DeletingContent(sender, eventArgs));
        }

        public static void DeletedContent(object sender, DeleteContentEventArgs eventArgs)
        {
            Runner.Run<IDeletedContent>(e => e.DeletedContent(sender, eventArgs));
        }
    }
}