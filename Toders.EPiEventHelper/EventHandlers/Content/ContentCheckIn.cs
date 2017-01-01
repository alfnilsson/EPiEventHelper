using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentCheckIn
    {
        private readonly IEventRunner _eventRunner;

        public ContentCheckIn(IEventRunner eventRunner)
        {
            this._eventRunner = eventRunner;
        }

        public void CheckingInContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckingInContent>(e => e.CheckingInContent(sender, args));
        }

        public void CheckedInContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckedInContent>(e => e.CheckedInContent(sender, args));
        }
    }
}