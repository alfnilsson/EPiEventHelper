using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentCreate
    {
        private readonly IEventRunner _eventRunner;

        public ContentCreate(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void CreatingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICreatingContent>(e => e.CreatingContent(sender, args));
        }

        public void CreatedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICreatedContent>(e => e.CreatedContent(sender, args));
        }
    }
}