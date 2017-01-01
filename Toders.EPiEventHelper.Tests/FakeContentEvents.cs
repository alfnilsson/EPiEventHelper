using System;
using System.Linq.Expressions;
using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Tests
{
    public class FakeContentEvents : IContentEvents
    {
        public event ChildrenEventHandler LoadingChildren;
        public event ChildrenEventHandler LoadedChildren;
        public event ChildrenEventHandler FailedLoadingChildren;
        public event EventHandler<ContentEventArgs> LoadingContent;
        public event EventHandler<ContentEventArgs> LoadedContent;
        public event EventHandler<ContentEventArgs> FailedLoadingContent;
        public event EventHandler<ContentEventArgs> LoadingDefaultContent;
        public event EventHandler<ContentEventArgs> LoadedDefaultContent;
        public event EventHandler<ContentEventArgs> PublishingContent;
        public event EventHandler<ContentEventArgs> PublishedContent;
        public event EventHandler<ContentEventArgs> CheckingInContent;
        public event EventHandler<ContentEventArgs> CheckedInContent;
        public event EventHandler<ContentEventArgs> RequestingApproval;
        public event EventHandler<ContentEventArgs> RequestedApproval;
        public event EventHandler<ContentEventArgs> RejectingContent;
        public event EventHandler<ContentEventArgs> RejectedContent;
        public event EventHandler<ContentEventArgs> CheckingOutContent;
        public event EventHandler<ContentEventArgs> CheckedOutContent;
        public event EventHandler<ContentEventArgs> SchedulingContent;
        public event EventHandler<ContentEventArgs> ScheduledContent;
        public event EventHandler<DeleteContentEventArgs> DeletingContent;
        public event EventHandler<DeleteContentEventArgs> DeletedContent;
        public event EventHandler<ContentEventArgs> CreatingContentLanguage;
        public event EventHandler<ContentEventArgs> CreatedContentLanguage;
        public event EventHandler<ContentEventArgs> DeletingContentLanguage;
        public event EventHandler<ContentEventArgs> DeletedContentLanguage;
        public event EventHandler<ContentEventArgs> MovingContent;
        public event EventHandler<ContentEventArgs> MovedContent;
        public event EventHandler<ContentEventArgs> CreatingContent;
        public event EventHandler<ContentEventArgs> CreatedContent;
        public event EventHandler<ContentEventArgs> SavingContent;
        public event EventHandler<ContentEventArgs> SavedContent;
        public event EventHandler<ContentEventArgs> DeletingContentVersion;
        public event EventHandler<ContentEventArgs> DeletedContentVersion;

        public void OnLoadingChildren()
        {
            LoadingChildren?.Invoke(null, null);
        }

        public void OnLoadedChildren()
        {
            LoadedChildren?.Invoke(null, null);
        }

        public void OnFailedLoadingChildren()
        {
            FailedLoadingChildren?.Invoke(null, null);
        }

        public void OnLoadingContent()
        {
            LoadingContent?.Invoke(null, null);
        }

        public void OnLoadedContent()
        {
            LoadedContent?.Invoke(null, null);
        }

        public void OnFailedLoadingContent()
        {
            FailedLoadingContent?.Invoke(null, null);
        }

        public void OnLoadingDefaultContent()
        {
            LoadingDefaultContent?.Invoke(null, null);
        }

        public void OnLoadedDefaultContent()
        {
            LoadedDefaultContent?.Invoke(null, null);
        }

        public void OnPublishingContent()
        {
            PublishingContent?.Invoke(null, null);
        }

        public void OnPublishedContent()
        {
            PublishedContent?.Invoke(null, null);
        }

        public void OnCheckingInContent()
        {
            CheckingInContent?.Invoke(null, null);
        }

        public void OnCheckedInContent()
        {
            CheckedInContent?.Invoke(null, null);
        }

        public void OnRequestingApproval()
        {
            RequestingApproval?.Invoke(null, null);
        }

        public void OnRequestedApproval()
        {
            RequestedApproval?.Invoke(null, null);
        }

        public void OnRejectingContent()
        {
            RejectingContent?.Invoke(null, null);
        }

        public void OnRejectedContent()
        {
            RejectedContent?.Invoke(null, null);
        }

        public void OnCheckingOutContent()
        {
            CheckingOutContent?.Invoke(null, null);
        }

        public void OnCheckedOutContent()
        {
            CheckedOutContent?.Invoke(null, null);
        }

        public void OnSchedulingContent()
        {
            SchedulingContent?.Invoke(null, null);
        }

        public void OnScheduledContent()
        {
            ScheduledContent?.Invoke(null, null);
        }

        public void OnDeletingContent()
        {
            DeletingContent?.Invoke(null, null);
        }

        public void OnDeletedContent()
        {
            DeletedContent?.Invoke(null, null);
        }

        public void OnCreatingContentLanguage()
        {
            CreatingContentLanguage?.Invoke(null, null);
        }

        public void OnCreatedContentLanguage()
        {
            CreatedContentLanguage?.Invoke(null, null);
        }

        public void OnDeletingContentLanguage()
        {
            DeletingContentLanguage?.Invoke(null, null);
        }

        public void OnDeletedContentLanguage()
        {
            DeletedContentLanguage?.Invoke(null, null);
        }

        public void OnMovingContent()
        {
            MovingContent?.Invoke(null, null);
        }

        public void OnMovedContent()
        {
            MovedContent?.Invoke(null, null);
        }

        public void OnCreatingContent()
        {
            CreatingContent?.Invoke(null, null);
        }

        public void OnCreatedContent()
        {
            CreatedContent?.Invoke(null, null);
        }

        public void OnSavingContent()
        {
            SavingContent?.Invoke(null, null);
        }

        public void OnSavedContent()
        {
            SavedContent?.Invoke(null, null);
        }

        public void OnDeletingContentVersion()
        {
            this.DeletingContentVersion?.Invoke(null, null);
        }

        public void OnDeletedContentVersion()
        {
            this.DeletedContentVersion?.Invoke(null, null);
        }
    }
}