using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentCheckOut
    {
        private IEventRunner _eventRunner;

        public ContentCheckOut(IEventRunner eventRunner)
        {
            this._eventRunner = eventRunner;
        }

        public void CheckingOutContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckingOutContent>(e => e.CheckingOutContent(sender, args));
        }

        public void CheckedOutContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckedOutContent>(e => e.CheckedOutContent(sender, args));
        }
    }
}