using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentDelete
    {
        public static void DeletingContent(object sender, DeleteContentEventArgs args)
        {
            EventRunner.Execute<IDeletingContent>(e => e.DeletingContent(sender, args));
        }

        public static void DeletedContent(object sender, DeleteContentEventArgs args)
        {
            EventRunner.Execute<IDeletedContent>(e => e.DeletedContent(sender, args));
        }
    }
}