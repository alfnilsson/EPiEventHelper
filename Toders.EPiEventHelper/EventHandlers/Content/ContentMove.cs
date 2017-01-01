using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentMove
    {
        private readonly IEventRunner _eventRunner;

        public ContentMove(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void MovingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IMovingContent>(e => e.MovingContent(sender, args));
        }

        public void MovedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IMovedContent>(e => e.MovedContent(sender, args));
        }
    }
}