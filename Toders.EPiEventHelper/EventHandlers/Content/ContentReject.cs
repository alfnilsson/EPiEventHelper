using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentReject
    {
        private readonly IEventRunner _eventRunner;

        public ContentReject(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void RejectingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRejectingContent>(e => e.RejectingContent(sender, args));
        }

        public void RejectedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRejectedContent>(e => e.RejectedContent(sender, args));
        }
    }
}