using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public class ContentDelete
    {
        private readonly IEventRunner _eventRunner;

        public ContentDelete(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void DeletingContent(object sender, DeleteContentEventArgs args)
        {
            _eventRunner.Run<IDeletingContent>(e => e.DeletingContent(sender, args));
        }

        public void DeletedContent(object sender, DeleteContentEventArgs args)
        {
            _eventRunner.Run<IDeletedContent>(e => e.DeletedContent(sender, args));
        }
    }
}