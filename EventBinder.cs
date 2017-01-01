using EPiServer.Core;
using EPiServer.ServiceLocation;
using Toders.EPiEventHelper.EventHandlers;
using Toders.EPiEventHelper.EventHandlers.Content;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper
{
    public class EventBinder
    {
        private readonly IContentEvents _contentEvents;
        private readonly Version _version;
        private readonly ContentSave _contentSave;
        private readonly ContentCreate _contentCreate;
        private ContentCheckIn _contentCheckIn;
        private ContentCheckOut _contentCheckOut;

        public EventBinder(IContentEvents contentEvents, IEventRunner eventRunner)
        {
            this._contentEvents = contentEvents;
            this._version = new Version(eventRunner);

            this._contentCreate = new ContentCreate(eventRunner);
            this._contentSave = new ContentSave(eventRunner);
            this._contentCheckIn = new ContentCheckIn(eventRunner);
            this._contentCheckOut = new ContentCheckOut(eventRunner);
        }

        public void BindEvents()
        {
            BindContentEvents(
                _contentEvents,
                _contentCreate,
                _contentSave,
                _contentCheckIn);
            //BindContentLanguageEvents(_contentEvents, _eventRunner);
            BindContentVersionEvents(_version, _contentEvents);
            //BindContentChildrenEvents(_contentEvents, _eventRunner);
        }

        public void UnbindEvents()
        {
            UnbindContentEvents(
                _contentEvents,
                _contentCreate,
                _contentSave,
                _contentCheckIn);
            //UnbindContentLanguageEvents(_contentEvents, _eventRunner);
            UnbindContentVersionEvents(_version, _contentEvents);
            //UnbindContentChildrenEvents(_contentEvents, _eventRunner);
        }

        private static void BindContentEvents(
            IContentEvents contentEvents,
            ContentCreate contentCreate,
            ContentSave contentSave,
            ContentCheckIn contentCheckIn)
        {
            contentEvents.CreatedContent += contentCreate.CreatedContent;
            contentEvents.CreatingContent += contentCreate.CreatingContent;

            contentEvents.SavingContent += contentSave.SavingContent;
            contentEvents.SavedContent += contentSave.SavedContent;

            contentEvents.CheckingInContent += contentCheckIn.CheckingInContent;
            contentEvents.CheckedInContent += contentCheckIn.CheckedInContent;

            contentEvents.CheckingOutContent += ContentCheckOut.CheckingOutContent;
            contentEvents.CheckedOutContent += ContentCheckOut.CheckedOutContent;

            contentEvents.RejectingContent += ContentReject.RejectingContent;
            contentEvents.RejectedContent += ContentReject.RejectedContent;

            contentEvents.RequestingApproval += ContentRequestApproval.RequestingApproval;
            contentEvents.RequestedApproval += ContentRequestApproval.RequestedApproval;

            contentEvents.PublishingContent += ContentPublish.PublishingContent;
            contentEvents.PublishedContent += ContentPublish.PublishedContent;

            contentEvents.MovingContent += ContentMove.MovingContent;
            contentEvents.MovedContent += ContentMove.MovedContent;

            contentEvents.DeletingContent += ContentDelete.DeletingContent;
            contentEvents.DeletedContent += ContentDelete.DeletedContent;

            contentEvents.LoadingContent += ContentLoad.LoadingContent;
            contentEvents.LoadedContent += ContentLoad.LoadedContent;
            contentEvents.FailedLoadingContent += ContentLoad.FailedLoadingContent;

            contentEvents.SchedulingContent += ContentSchedule.SchedulingContent;
            contentEvents.ScheduledContent += ContentSchedule.ScheduledContent;

            contentEvents.LoadingDefaultContent += DefaultContentLoad.LoadingDefaultContent;
            contentEvents.LoadedDefaultContent += DefaultContentLoad.LoadedDefaultContent;
        }

        private static void BindContentLanguageEvents(IContentEvents contentEvents, IEventRunner eventRunner)
        {
            Language language = new Language(eventRunner);
            contentEvents.CreatingContentLanguage += language.CreatingContentLanguage;
            contentEvents.CreatedContentLanguage += language.CreatedContentLanguage;

            contentEvents.DeletingContentLanguage += language.DeletingContentLanguage;
            contentEvents.DeletedContentLanguage += language.DeletedContentLanguage;
        }

        private static void BindContentVersionEvents(Version version, IContentEvents contentEvents)
        {
            contentEvents.DeletingContentVersion += version.DeletingContentVersion;
            contentEvents.DeletedContentVersion += version.DeletedContentVersion;
        }

        private static void BindContentChildrenEvents(IContentEvents contentEvents, IEventRunner eventRunner)
        {
            Children children = new Children(eventRunner);
            contentEvents.LoadingChildren += children.LoadingChildren;
            contentEvents.LoadedChildren += children.LoadedChildren;
            contentEvents.FailedLoadingChildren += children.FailedLoadingChildren;
        }

        private static void UnbindContentEvents(IContentEvents contentEvents, ContentCreate contentCreate, ContentSave contentSave, ContentCheckIn contentCheckIn)
        {
            contentEvents.CreatedContent -= contentCreate.CreatedContent;
            contentEvents.CreatingContent -= contentCreate.CreatingContent;

            contentEvents.SavingContent -= contentSave.SavingContent;
            contentEvents.SavedContent -= contentSave.SavedContent;

            contentEvents.CheckingInContent -= contentCheckIn.CheckingInContent;
            contentEvents.CheckedInContent -= contentCheckIn.CheckedInContent;

            contentEvents.CheckingOutContent -= ContentCheckOut.CheckingOutContent;
            contentEvents.CheckedOutContent -= ContentCheckOut.CheckedOutContent;

            contentEvents.RejectingContent -= ContentReject.RejectingContent;
            contentEvents.RejectedContent -= ContentReject.RejectedContent;

            contentEvents.RequestingApproval -= ContentRequestApproval.RequestingApproval;
            contentEvents.RequestedApproval -= ContentRequestApproval.RequestedApproval;

            contentEvents.PublishingContent -= ContentPublish.PublishingContent;
            contentEvents.PublishedContent -= ContentPublish.PublishedContent;

            contentEvents.MovingContent -= ContentMove.MovingContent;
            contentEvents.MovedContent -= ContentMove.MovedContent;

            contentEvents.DeletingContent -= ContentDelete.DeletingContent;
            contentEvents.DeletedContent -= ContentDelete.DeletedContent;

            contentEvents.LoadingContent -= ContentLoad.LoadingContent;
            contentEvents.LoadedContent -= ContentLoad.LoadedContent;
            contentEvents.FailedLoadingContent -= ContentLoad.FailedLoadingContent;

            contentEvents.SchedulingContent -= ContentSchedule.SchedulingContent;
            contentEvents.ScheduledContent -= ContentSchedule.ScheduledContent;

            contentEvents.LoadingDefaultContent -= DefaultContentLoad.LoadingDefaultContent;
            contentEvents.LoadedDefaultContent -= DefaultContentLoad.LoadedDefaultContent;
        }

        private static void UnbindContentLanguageEvents(IContentEvents contentEvents, IEventRunner eventRunner)
        {
            Language language = new Language(eventRunner);
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

        private static void UnbindContentChildrenEvents(IContentEvents contentEvents, IEventRunner eventRunner)
        {
            Children children = new Children(eventRunner);
            contentEvents.LoadingChildren -= children.LoadingChildren;
            contentEvents.LoadedChildren -= children.LoadedChildren;
            contentEvents.FailedLoadingChildren -= children.FailedLoadingChildren;
        }
    }
}