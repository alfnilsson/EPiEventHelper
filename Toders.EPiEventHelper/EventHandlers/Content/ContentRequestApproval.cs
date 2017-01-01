using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentRequestApproval
    {
        private readonly IEventRunner _eventRunner;

        public ContentRequestApproval(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void RequestingApproval(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRequestingApproval>(e => e.RequestingApproval(sender, args));
        }

        public void RequestedApproval(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRequestedApproval>(e => e.RequestedApproval(sender, args));
        }
    }
}