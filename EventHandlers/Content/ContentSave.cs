using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentSave
    {
        private readonly IEventRunner _eventRunner;

        public ContentSave(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void SavingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ISavingContent>(e => e.SavingContent(sender, args));
        }

        public void SavedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ISavedContent>(e => e.SavedContent(sender, args));
        }
    }
}