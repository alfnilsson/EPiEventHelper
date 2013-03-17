using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper
{
    public class DataFactoryEvents
    {
        #region [ Checking In ]

        public static void CheckedInContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ICheckedInContent;
            if (content == null)
                return;

            content.CheckedInContent(sender, e);
        }

        public static void CheckedInPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ICheckedInPage;
            if (pageData == null)
                return;

            pageData.CheckedInPage(sender, e);
        }

        public static void CheckingInContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ICheckingInContent;
            if (content == null)
                return;

            content.CheckingInContent(sender, e);
        }

        public static void CheckingInPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ICheckingInPage;
            if (pageData == null)
                return;

            pageData.CheckingInPage(sender, e);
        }

        #endregion

        #region [ Creating ]

        public static void CreatedContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ICreatedContent;
            if (content == null)
                return;

            content.CreatedContent(sender, e);
        }

        public static void CreatedPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ICreatedPage;
            if (pageData == null)
                return;

            pageData.CreatedPage(sender, e);
        }

        public static void CreatingContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ICreatingContent;
            if (content == null)
                return;

            content.CreatingContent(sender, e);
        }

        public static void CreatingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ICreatingPage;
            if (pageData == null)
                return;

            pageData.CreatingPage(sender, e);
        }

        #endregion

        #region [ Deleting ]

        public static void DeletedContent(object sender, DeleteContentEventArgs e)
        {
            var content = e.Content as IDeletedContent;
            if (content == null)
                return;

            content.DeletedContent(sender, e);
        }

        public static void DeletedContentLanguage(object sender, ContentEventArgs e)
        {
            var content = e.Content as IDeletedContentLanguage;
            if (content == null)
                return;

            content.DeletedContentLanguage(sender, e);
        }

        public static void DeletedContentVersion(object sender, ContentEventArgs e)
        {
            var content = e.Content as IDeletedContentVersion;
            if (content == null)
                return;

            content.DeletedContentVersion(sender, e);
        }

        public static void DeletedPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IDeletedPage;
            if (pageData == null)
                return;

            pageData.DeletedPage(sender, e);
        }

        public static void DeletedPageLanguage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IDeletedPageLanguage;
            if (pageData == null)
                return;

            pageData.DeletedPageLanguage(sender, e);
        }

        public static void DeletingContent(object sender, DeleteContentEventArgs e)
        {
            var content = e.Content as IDeletingContent;
            if (content == null)
                return;

            content.DeletingContent(sender, e);
        }

        public static void DeletingContentLanguage(object sender, ContentEventArgs e)
        {
            var content = e.Content as IDeletingContentLanguage;
            if (content == null)
                return;

            content.DeletingContentLanguage(sender, e);
        }

        public static void DeletingContentVersion(object sender, ContentEventArgs e)
        {
            var content = e.Content as IDeletingContentVersion;
            if (content == null)
                return;

            content.DeletingContentVersion(sender, e);
        }

        public static void DeletingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IDeletingPage;
            if (pageData == null)
                return;

            pageData.DeletingPage(sender, e);
        }

        public static void DeletingPageLanguage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IDeletingPageLanguage;
            if (pageData == null)
                return;

            pageData.DeletingPageLanguage(sender, e);
        }

        #endregion

        #region [ Loading ]

        public static void FailedLoadingContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as IFailedLoadingContent;
            if (content == null)
                return;

            content.FailedLoadingContent(sender, e);
        }

        public static void FailedLoadingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IFailedLoadingPage;
            if (pageData == null)
                return;

            pageData.FailedLoadingPage(sender, e);
        }

        public static void FinishedLoadingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IFinishedLoadingPage;
            if (pageData == null)
                return;

            pageData.FinishedLoadingPage(sender, e);
        }

        public static void LoadedContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ILoadedContent;
            if (content == null)
                return;

            content.LoadedContent(sender, e);
        }

        public static void LoadedDefaultContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ILoadedDefaultContent;
            if (content == null)
                return;

            content.LoadedDefaultContent(sender, e);
        }

        public static void LoadedDefaultPageData(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ILoadedDefaultPageData;
            if (pageData == null)
                return;

            pageData.LoadedDefaultPageData(sender, e);
        }

        public static void LoadedPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ILoadedPage;
            if (pageData == null)
                return;

            pageData.LoadedPage(sender, e);
        }

        public static void LoadingContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ILoadingContent;
            if (content == null)
                return;

            content.LoadingContent(sender, e);
        }

        public static void LoadingDefaultContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ILoadingDefaultContent;
            if (content == null)
                return;

            content.LoadingDefaultContent(sender, e);
        }

        public static void LoadingDefaultPageData(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ILoadingDefaultPageData;
            if (pageData == null)
                return;

            pageData.LoadingDefaultPageData(sender, e);
        }

        public static void LoadingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ILoadingPage;
            if (pageData == null)
                return;

            pageData.LoadingPage(sender, e);
        }

        #endregion

        #region [ Moving ]

        public static void MovedContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as IMovedContent;
            if (content == null)
                return;

            content.MovedContent(sender, e);
        }

        public static void MovedPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IMovedPage;
            if (pageData == null)
                return;

            pageData.MovedPage(sender, e);
        }

        public static void MovingContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as IMovingContent;
            if (content == null)
                return;

            content.MovingContent(sender, e);
        }

        public static void MovingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IMovingPage;
            if (pageData == null)
                return;

            pageData.MovingPage(sender, e);
        }

        #endregion

        #region [ Publishing ]

        public static void PublishedContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as IPublishedContent;
            if (content == null)
                return;

            content.PublishedContent(sender, e);
        }

        public static void PublishedPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IPublishedPage;
            if (pageData == null)
                return;

            pageData.PublishedPage(sender, e);
        }

        public static void PublishingContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as IPublishingContent;
            if (content == null)
                return;

            content.PublishingContent(sender, e);
        }

        public static void PublishingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as IPublishingPage;
            if (pageData == null)
                return;

            pageData.PublishingPage(sender, e);
        }

        #endregion

        #region [ Saving ]

        public static void SavedContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ISavedContent;
            if (content == null)
                return;

            content.SavedContent(sender, e);
        }

        public static void SavedPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ISavedPage;
            if (pageData == null)
                return;

            pageData.SavedPage(sender, e);
        }

        public static void SavingContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as ISavingContent;
            if (content == null)
                return;

            content.SavingContent(sender, e);
        }

        public static void SavingPage(object sender, PageEventArgs e)
        {
            var pageData = e.Page as ISavingPage;
            if (pageData == null)
                return;

            pageData.SavingPage(sender, e);
        }

        #endregion
    }
}
