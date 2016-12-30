using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers
{
    public static class Language
    {
        public static void CreatingContentLanguage(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICreatingContentLanguage>(e => e.CreatingContentLanguage(sender, eventArgs));
        }

        public static void CreatedContentLanguage(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ICreatedContentLanguage>(e => e.CreatedContentLanguage(sender, eventArgs));
        }

        public static void DeletingContentLanguage(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IDeletingContentLanguage>(e => e.DeletingContentLanguage(sender, eventArgs));
        }

        public static void DeletedContentLanguage(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IDeletedContentLanguage>(e => e.DeletedContentLanguage(sender, eventArgs));
        }
    }
}