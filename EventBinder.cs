using EPiServer.Core;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using Toders.EPiEventHelper.EventHandlers;
using Toders.EPiEventHelper.EventHandlers.Content;

namespace Toders.EPiEventHelper
{
    public class EventBinder
    {
        public static void BindEvents()
        {
            IContentEvents contentEvents = ServiceLocator.Current.GetInstance<IContentEvents>();

            BindContentEvents(contentEvents);
            BindContentLanguageEvents(contentEvents);
            BindContentVersionEvents(contentEvents);
            BindContentChildrenEvents(contentEvents);
        }

        public static void UnbindEvents()
        {
            IContentEvents contentEvents = ServiceLocator.Current.GetInstance<IContentEvents>();

            UnbindContentEvents(contentEvents);
            UnbindContentLanguageEvents(contentEvents);
            UnbindContentVersionEvents(contentEvents);
            UnbindContentChildrenEvents(contentEvents);
        }

        private static void BindContentEvents(IContentEvents contentEvents)
        {
            contentEvents.CreatedContent += ContentCreate.CreatedContent;
            contentEvents.CreatingContent += ContentCreate.CreatingContent;

            contentEvents.SavingContent += ContentSave.SavingContent;
            contentEvents.SavedContent += ContentSave.SavedContent;

            contentEvents.CheckingInContent += ContentCheckIn.CheckingInContent;
            contentEvents.CheckedInContent += ContentCheckIn.CheckedInContent;

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

        private static void BindContentLanguageEvents(IContentEvents contentEvents)
        {
            contentEvents.CreatingContentLanguage += Language.CreatingContentLanguage;
            contentEvents.CreatedContentLanguage += Language.CreatedContentLanguage;

            contentEvents.DeletedContentLanguage += Language.DeletedContentLanguage;
            contentEvents.DeletingContentLanguage += Language.DeletingContentLanguage;
        }

        private static void BindContentVersionEvents(IContentEvents contentEvents)
        {
            contentEvents.DeletingContentVersion += Version.DeletingContentVersion;
            contentEvents.DeletedContentVersion += Version.DeletedContentVersion;
        }

        private static void BindContentChildrenEvents(IContentEvents contentEvents)
        {
            contentEvents.LoadingChildren += Children.LoadingChildren;
            contentEvents.LoadedChildren += Children.LoadedChildren;
            contentEvents.FailedLoadingChildren += Children.FailedLoadingChildren;
        }

        private static void UnbindContentEvents(IContentEvents contentEvents)
        {
            contentEvents.CreatedContent -= ContentCreate.CreatedContent;
            contentEvents.CreatingContent -= ContentCreate.CreatingContent;

            contentEvents.SavingContent -= ContentSave.SavingContent;
            contentEvents.SavedContent -= ContentSave.SavedContent;

            contentEvents.CheckingInContent -= ContentCheckIn.CheckingInContent;
            contentEvents.CheckedInContent -= ContentCheckIn.CheckedInContent;

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

        private static void UnbindContentLanguageEvents(IContentEvents contentEvents)
        {
            contentEvents.CreatingContentLanguage -= Language.CreatingContentLanguage;
            contentEvents.CreatedContentLanguage -= Language.CreatedContentLanguage;

            contentEvents.DeletedContentLanguage -= Language.DeletedContentLanguage;
            contentEvents.DeletingContentLanguage -= Language.DeletingContentLanguage;
        }

        private static void UnbindContentVersionEvents(IContentEvents contentEvents)
        {
            contentEvents.DeletingContentVersion -= Version.DeletingContentVersion;
            contentEvents.DeletedContentVersion -= Version.DeletedContentVersion;
        }

        private static void UnbindContentChildrenEvents(IContentEvents contentEvents)
        {
            contentEvents.LoadingChildren -= Children.LoadingChildren;
            contentEvents.LoadedChildren -= Children.LoadedChildren;
            contentEvents.FailedLoadingChildren -= Children.FailedLoadingChildren;
        }
    }
}