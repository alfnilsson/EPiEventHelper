using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers
{
    public class Version
    {
        private readonly IEventRunner _eventRunner;

        public Version(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void DeletingContentVersion(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IDeletingContentVersion>(e => e.DeletingContentVersion(sender, args));
        }

        public void DeletedContentVersion(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IDeletedContentVersion>(e => e.DeletedContentVersion(sender, args));
        }
    }
}