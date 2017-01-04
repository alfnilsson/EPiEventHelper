using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper
{
    public class EventBinder
    {
        private readonly IContentEvents _contentEvents;

        private readonly IEventRunner _eventRunner;

        public EventBinder(IContentEvents contentEvents, IEventRunner eventRunner)
        {
            _contentEvents = contentEvents;

            _eventRunner = eventRunner;
        }

        public void BindEvents()
        {
            _contentEvents.CreatedContent += CreatedContent;
            _contentEvents.CreatingContent += CreatingContent;

            _contentEvents.SavingContent += SavingContent;
            _contentEvents.SavedContent += SavedContent;

            _contentEvents.CheckingInContent += CheckingInContent;
            _contentEvents.CheckedInContent += CheckedInContent;

            _contentEvents.CheckingOutContent += CheckingOutContent;
            _contentEvents.CheckedOutContent += CheckedOutContent;

            _contentEvents.RejectingContent += RejectingContent;
            _contentEvents.RejectedContent += RejectedContent;

            _contentEvents.RequestingApproval += RequestingApproval;
            _contentEvents.RequestedApproval += RequestedApproval;

            _contentEvents.PublishingContent += PublishingContent;
            _contentEvents.PublishedContent += PublishedContent;

            _contentEvents.MovingContent += MovingContent;
            _contentEvents.MovedContent += MovedContent;

            _contentEvents.DeletingContent += DeletingContent;
            _contentEvents.DeletedContent += DeletedContent;

            _contentEvents.LoadingContent += LoadingContent;
            _contentEvents.LoadedContent += LoadedContent;
            _contentEvents.FailedLoadingContent += FailedLoadingContent;

            _contentEvents.SchedulingContent += SchedulingContent;
            _contentEvents.ScheduledContent += ScheduledContent;

            _contentEvents.LoadingDefaultContent += LoadingDefaultContent;
            _contentEvents.LoadedDefaultContent += LoadedDefaultContent;

            _contentEvents.CreatingContentLanguage += CreatingContentLanguage;
            _contentEvents.CreatedContentLanguage += CreatedContentLanguage;

            _contentEvents.DeletingContentLanguage += DeletingContentLanguage;
            _contentEvents.DeletedContentLanguage += DeletedContentLanguage;

            _contentEvents.DeletingContentVersion += DeletingContentVersion;
            _contentEvents.DeletedContentVersion += DeletedContentVersion;

            _contentEvents.LoadingChildren += LoadingChildren;
            _contentEvents.LoadedChildren += LoadedChildren;
            _contentEvents.FailedLoadingChildren += FailedLoadingChildren;
        }

        public void UnbindEvents()
        {
            _contentEvents.CreatedContent -= CreatedContent;
            _contentEvents.CreatingContent -= CreatingContent;

            _contentEvents.SavingContent -= SavingContent;
            _contentEvents.SavedContent -= SavedContent;

            _contentEvents.CheckingInContent -= CheckingInContent;
            _contentEvents.CheckedInContent -= CheckedInContent;

            _contentEvents.CheckingOutContent -= CheckingOutContent;
            _contentEvents.CheckedOutContent -= CheckedOutContent;

            _contentEvents.RejectingContent -= RejectingContent;
            _contentEvents.RejectedContent -= RejectedContent;

            _contentEvents.RequestingApproval -= RequestingApproval;
            _contentEvents.RequestedApproval -= RequestedApproval;

            _contentEvents.PublishingContent -= PublishingContent;
            _contentEvents.PublishedContent -= PublishedContent;

            _contentEvents.MovingContent -= MovingContent;
            _contentEvents.MovedContent -= MovedContent;

            _contentEvents.DeletingContent -= DeletingContent;
            _contentEvents.DeletedContent -= DeletedContent;

            _contentEvents.LoadingContent -= LoadingContent;
            _contentEvents.LoadedContent -= LoadedContent;
            _contentEvents.FailedLoadingContent -= FailedLoadingContent;

            _contentEvents.SchedulingContent -= SchedulingContent;
            _contentEvents.ScheduledContent -= ScheduledContent;

            _contentEvents.LoadingDefaultContent -= LoadingDefaultContent;
            _contentEvents.LoadedDefaultContent -= LoadedDefaultContent;

            _contentEvents.CreatingContentLanguage -= CreatingContentLanguage;
            _contentEvents.CreatedContentLanguage -= CreatedContentLanguage;

            _contentEvents.DeletingContentLanguage -= DeletingContentLanguage;
            _contentEvents.DeletedContentLanguage -= DeletedContentLanguage;

            _contentEvents.DeletingContentVersion -= DeletingContentVersion;
            _contentEvents.DeletedContentVersion -= DeletedContentVersion;

            _contentEvents.LoadingChildren -= LoadingChildren;
            _contentEvents.LoadedChildren -= LoadedChildren;
            _contentEvents.FailedLoadingChildren -= FailedLoadingChildren;
        }

        #region [ Content ]

        public void CheckingInContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckingInContent>(e => e.CheckingInContent(sender, args));
        }

        public void CheckedInContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckedInContent>(e => e.CheckedInContent(sender, args));
        }

        public void CheckingOutContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckingOutContent>(e => e.CheckingOutContent(sender, args));
        }

        public void CheckedOutContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICheckedOutContent>(e => e.CheckedOutContent(sender, args));
        }

        public void CreatingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICreatingContent>(e => e.CreatingContent(sender, args));
        }

        public void CreatedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ICreatedContent>(e => e.CreatedContent(sender, args));
        }

        public void DeletingContent(object sender, DeleteContentEventArgs args)
        {
            _eventRunner.Run<IDeletingContent>(e => e.DeletingContent(sender, args));
        }

        public void DeletedContent(object sender, DeleteContentEventArgs args)
        {
            _eventRunner.Run<IDeletedContent>(e => e.DeletedContent(sender, args));
        }

        public void LoadingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadingContent>(e => e.LoadingContent(sender, args));
        }

        public void LoadedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadedContent>(e => e.LoadedContent(sender, args));
        }

        public void FailedLoadingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IFailedLoadingContent>(e => e.FailedLoadingContent(sender, args));
        }

        public void MovingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IMovingContent>(e => e.MovingContent(sender, args));
        }

        public void MovedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IMovedContent>(e => e.MovedContent(sender, args));
        }

        public void PublishingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IPublishingContent>(e => e.PublishingContent(sender, args));
        }

        public void PublishedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IPublishedContent>(e => e.PublishedContent(sender, args));
        }

        public void RejectingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRejectingContent>(e => e.RejectingContent(sender, args));
        }

        public void RejectedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRejectedContent>(e => e.RejectedContent(sender, args));
        }

        public void RequestingApproval(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRequestingApproval>(e => e.RequestingApproval(sender, args));
        }

        public void RequestedApproval(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IRequestedApproval>(e => e.RequestedApproval(sender, args));
        }

        public void SavingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ISavingContent>(e => e.SavingContent(sender, args));
        }

        public void SavedContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ISavedContent>(e => e.SavedContent(sender, args));
        }

        public void SchedulingContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ISchedulingContent>(e => e.SchedulingContent(sender, args));
        }

        public void ScheduledContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IScheduledContent>(e => e.ScheduledContent(sender, args));
        }

        #endregion

        #region [ Default Content ]

        public void LoadingDefaultContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadingDefaultContent>(e => e.LoadingDefaultContent(sender, args));
        }

        public void LoadedDefaultContent(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<ILoadedDefaultContent>(e => e.LoadedDefaultContent(sender, args));
        }

        #endregion

        #region [ Children ]

        public void LoadingChildren(object sender, ChildrenEventArgs args)
        {
            _eventRunner.Run<ILoadingChildren>(e => e.LoadingChildren(sender, args));
        }

        public void LoadedChildren(object sender, ChildrenEventArgs args)
        {
            _eventRunner.Run<ILoadedChildren>(e => e.LoadedChildren(sender, args));
        }

        public void FailedLoadingChildren(object sender, ChildrenEventArgs args)
        {
            _eventRunner.Run<IFailedLoadingChildren>(e => e.FailedLoadingChildren(sender, args));
        }

        #endregion

        #region [ Content Language ]

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

        #endregion

        #region [ Content Version ]

        public void DeletingContentVersion(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IDeletingContentVersion>(e => e.DeletingContentVersion(sender, args));
        }

        public void DeletedContentVersion(object sender, ContentEventArgs args)
        {
            _eventRunner.Run<IDeletedContentVersion>(e => e.DeletedContentVersion(sender, args));
        }

        #endregion
    }
}