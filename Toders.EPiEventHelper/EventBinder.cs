using EPiServer.Core;
using Toders.EPiEventHelper.EventHandlers;
using Toders.EPiEventHelper.EventHandlers.Content;

namespace Toders.EPiEventHelper
{
    public class EventBinder
    {
        private readonly IContentEvents _contentEvents;
        private readonly Version _version;
        private readonly ContentSave _contentSave;
        private readonly ContentCreate _contentCreate;
        private readonly ContentCheckIn _contentCheckIn;
        private readonly ContentCheckOut _contentCheckOut;
        private readonly ContentReject _contentReject;
        private readonly ContentRequestApproval _contentRequestApproval;
        private readonly ContentPublish _contentPublish;
        private readonly ContentMove _contentMove;
        private readonly ContentDelete _contentDelete;
        private readonly ContentLoad _contentLoad;
        private readonly ContentSchedule _contentSchedule;
        private readonly DefaultContentLoad _defaultContentLoad;
        private readonly Language _language;
        private Children _children;

        public EventBinder(IContentEvents contentEvents, IEventRunner eventRunner)
        {
            _contentEvents = contentEvents;

            _version = new Version(eventRunner);
            _language = new Language(eventRunner);
            _children = new Children(eventRunner);

            _contentCreate = new ContentCreate(eventRunner);
            _contentSave = new ContentSave(eventRunner);
            _contentCheckIn = new ContentCheckIn(eventRunner);
            _contentCheckOut = new ContentCheckOut(eventRunner);
            _contentReject = new ContentReject(eventRunner);
            _contentRequestApproval = new ContentRequestApproval(eventRunner);
            _contentPublish = new ContentPublish(eventRunner);
            _contentMove = new ContentMove(eventRunner);
            _contentDelete = new ContentDelete(eventRunner);
            _contentLoad = new ContentLoad(eventRunner);
            _contentSchedule = new ContentSchedule(eventRunner);
            _defaultContentLoad = new DefaultContentLoad(eventRunner);
        }

        public void BindEvents()
        {
            BindContentEvents(
                _contentEvents,
                _contentCreate,
                _contentSave,
                _contentCheckIn,
                _contentCheckOut,
                _contentReject,
                _contentRequestApproval,
                _contentPublish,
                _contentMove,
                _contentDelete,
                _contentLoad,
                _contentSchedule,
                _defaultContentLoad);
            BindContentLanguageEvents(_contentEvents, _language);
            BindContentVersionEvents(_contentEvents, _version);
            BindContentChildrenEvents(_contentEvents, _children);
        }

        public void UnbindEvents()
        {
            UnbindContentEvents(
                _contentEvents,
                _contentCreate,
                _contentSave,
                _contentCheckIn,
                _contentCheckOut,
                _contentReject,
                _contentRequestApproval,
                _contentPublish,
                _contentMove,
                _contentDelete,
                _contentLoad,
                _contentSchedule,
                _defaultContentLoad);
            UnbindContentLanguageEvents(_contentEvents, _language);
            UnbindContentVersionEvents(_version, _contentEvents);
            UnbindContentChildrenEvents(_contentEvents, _children);
        }

        private static void BindContentEvents(IContentEvents contentEvents, ContentCreate contentCreate, ContentSave contentSave, ContentCheckIn contentCheckIn, ContentCheckOut contentCheckOut, ContentReject contentReject, ContentRequestApproval contentRequestApproval, ContentPublish contentPublish, ContentMove contentMove, ContentDelete contentDelete, ContentLoad contentLoad, ContentSchedule contentSchedule, DefaultContentLoad defaultContentLoad)
        {
            contentEvents.CreatedContent += contentCreate.CreatedContent;
            contentEvents.CreatingContent += contentCreate.CreatingContent;

            contentEvents.SavingContent += contentSave.SavingContent;
            contentEvents.SavedContent += contentSave.SavedContent;

            contentEvents.CheckingInContent += contentCheckIn.CheckingInContent;
            contentEvents.CheckedInContent += contentCheckIn.CheckedInContent;

            contentEvents.CheckingOutContent += contentCheckOut.CheckingOutContent;
            contentEvents.CheckedOutContent += contentCheckOut.CheckedOutContent;

            contentEvents.RejectingContent += contentReject.RejectingContent;
            contentEvents.RejectedContent += contentReject.RejectedContent;

            contentEvents.RequestingApproval += contentRequestApproval.RequestingApproval;
            contentEvents.RequestedApproval += contentRequestApproval.RequestedApproval;

            contentEvents.PublishingContent += contentPublish.PublishingContent;
            contentEvents.PublishedContent += contentPublish.PublishedContent;

            contentEvents.MovingContent += contentMove.MovingContent;
            contentEvents.MovedContent += contentMove.MovedContent;

            contentEvents.DeletingContent += contentDelete.DeletingContent;
            contentEvents.DeletedContent += contentDelete.DeletedContent;

            contentEvents.LoadingContent += contentLoad.LoadingContent;
            contentEvents.LoadedContent += contentLoad.LoadedContent;
            contentEvents.FailedLoadingContent += contentLoad.FailedLoadingContent;

            contentEvents.SchedulingContent += contentSchedule.SchedulingContent;
            contentEvents.ScheduledContent += contentSchedule.ScheduledContent;

            contentEvents.LoadingDefaultContent += defaultContentLoad.LoadingDefaultContent;
            contentEvents.LoadedDefaultContent += defaultContentLoad.LoadedDefaultContent;
        }

        private static void BindContentLanguageEvents(IContentEvents contentEvents, Language language)
        {
            contentEvents.CreatingContentLanguage += language.CreatingContentLanguage;
            contentEvents.CreatedContentLanguage += language.CreatedContentLanguage;

            contentEvents.DeletingContentLanguage += language.DeletingContentLanguage;
            contentEvents.DeletedContentLanguage += language.DeletedContentLanguage;
        }

        private static void BindContentVersionEvents(IContentEvents contentEvents, Version version)
        {
            contentEvents.DeletingContentVersion += version.DeletingContentVersion;
            contentEvents.DeletedContentVersion += version.DeletedContentVersion;
        }

        private static void BindContentChildrenEvents(IContentEvents contentEvents, Children children)
        {
            contentEvents.LoadingChildren += children.LoadingChildren;
            contentEvents.LoadedChildren += children.LoadedChildren;
            contentEvents.FailedLoadingChildren += children.FailedLoadingChildren;
        }

        private static void UnbindContentEvents(IContentEvents contentEvents, ContentCreate contentCreate, ContentSave contentSave, ContentCheckIn contentCheckIn, ContentCheckOut contentCheckOut, ContentReject contentReject, ContentRequestApproval contentRequestApproval, ContentPublish contentPublish, ContentMove contentMove, ContentDelete contentDelete, ContentLoad contentLoad, ContentSchedule contentSchedule, DefaultContentLoad defaultContentLoad)
        {
            contentEvents.CreatedContent -= contentCreate.CreatedContent;
            contentEvents.CreatingContent -= contentCreate.CreatingContent;

            contentEvents.SavingContent -= contentSave.SavingContent;
            contentEvents.SavedContent -= contentSave.SavedContent;

            contentEvents.CheckingInContent -= contentCheckIn.CheckingInContent;
            contentEvents.CheckedInContent -= contentCheckIn.CheckedInContent;

            contentEvents.CheckingOutContent -= contentCheckOut.CheckingOutContent;
            contentEvents.CheckedOutContent -= contentCheckOut.CheckedOutContent;

            contentEvents.RejectingContent -= contentReject.RejectingContent;
            contentEvents.RejectedContent -= contentReject.RejectedContent;

            contentEvents.RequestingApproval -= contentRequestApproval.RequestingApproval;
            contentEvents.RequestedApproval -= contentRequestApproval.RequestedApproval;

            contentEvents.PublishingContent -= contentPublish.PublishingContent;
            contentEvents.PublishedContent -= contentPublish.PublishedContent;

            contentEvents.MovingContent -= contentMove.MovingContent;
            contentEvents.MovedContent -= contentMove.MovedContent;

            contentEvents.DeletingContent -= contentDelete.DeletingContent;
            contentEvents.DeletedContent -= contentDelete.DeletedContent;

            contentEvents.LoadingContent -= contentLoad.LoadingContent;
            contentEvents.LoadedContent -= contentLoad.LoadedContent;
            contentEvents.FailedLoadingContent -= contentLoad.FailedLoadingContent;

            contentEvents.SchedulingContent -= contentSchedule.SchedulingContent;
            contentEvents.ScheduledContent -= contentSchedule.ScheduledContent;

            contentEvents.LoadingDefaultContent -= defaultContentLoad.LoadingDefaultContent;
            contentEvents.LoadedDefaultContent -= defaultContentLoad.LoadedDefaultContent;
        }

        private static void UnbindContentLanguageEvents(IContentEvents contentEvents, Language language)
        {
            contentEvents.CreatingContentLanguage -= language.CreatingContentLanguage;
            contentEvents.CreatedContentLanguage -= language.CreatedContentLanguage;

            contentEvents.DeletedContentLanguage -= language.DeletedContentLanguage;
            contentEvents.DeletingContentLanguage -= language.DeletingContentLanguage;
        }

        private static void UnbindContentVersionEvents(Version version, IContentEvents contentEvents)
        {
            contentEvents.DeletingContentVersion -= version.DeletingContentVersion;
            contentEvents.DeletedContentVersion -= version.DeletedContentVersion;
        }

        private static void UnbindContentChildrenEvents(IContentEvents contentEvents, Children children)
        {
            contentEvents.LoadingChildren -= children.LoadingChildren;
            contentEvents.LoadedChildren -= children.LoadedChildren;
            contentEvents.FailedLoadingChildren -= children.FailedLoadingChildren;
        }
    }
}