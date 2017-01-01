using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers
{
    public class Language
    {
        private readonly IEventRunner _eventRunner;

        public Language(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

        public void CreatingContentLanguage(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICreatingContentLanguage>(e => e.CreatingContentLanguage(sender, args));
        }

        public void CreatedContentLanguage(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICreatedContentLanguage>(e => e.CreatedContentLanguage(sender, args));
        }

        public void DeletingContentLanguage(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IDeletingContentLanguage>(e => e.DeletingContentLanguage(sender, args));
        }

        public void DeletedContentLanguage(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IDeletedContentLanguage>(e => e.DeletedContentLanguage(sender, args));
        }
    }
}