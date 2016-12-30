using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentSave
    {
        public static void SavingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ISavingContent>(e => e.SavingContent(sender, eventArgs));
        }

        public static void SavedContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ISavedContent>(e => e.SavedContent(sender, eventArgs));
        }
    }
}