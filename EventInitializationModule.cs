using EPiServer;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Toders.EPiEventHelper
{
    [InitializableModule]
    public class EventInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            DataFactory.Instance.CheckedInContent += DataFactoryEvents.CheckedInContent;
            DataFactory.Instance.CheckedInPage += DataFactoryEvents.CheckedInPage;

            DataFactory.Instance.CheckingInContent += DataFactoryEvents.CheckingInContent;
            DataFactory.Instance.CheckingInPage += DataFactoryEvents.CheckingInPage;

            DataFactory.Instance.CreatedContent += DataFactoryEvents.CreatedContent;
            DataFactory.Instance.CreatedPage += DataFactoryEvents.CreatedPage;

            DataFactory.Instance.CreatingContent += DataFactoryEvents.CreatingContent;
            DataFactory.Instance.CreatingPage += DataFactoryEvents.CreatingPage;

            DataFactory.Instance.DeletedContent += DataFactoryEvents.DeletedContent;
            DataFactory.Instance.DeletedContentLanguage += DataFactoryEvents.DeletedContentLanguage;
            DataFactory.Instance.DeletedContentVersion += DataFactoryEvents.DeletedContentVersion;
            DataFactory.Instance.DeletedPage += DataFactoryEvents.DeletedPage;
            DataFactory.Instance.DeletedPageLanguage += DataFactoryEvents.DeletedPageLanguage;

            DataFactory.Instance.DeletingContent += DataFactoryEvents.DeletingContent;
            DataFactory.Instance.DeletingContentLanguage += DataFactoryEvents.DeletingContentLanguage;
            DataFactory.Instance.DeletingContentVersion += DataFactoryEvents.DeletingContentVersion;
            DataFactory.Instance.DeletingPage += DataFactoryEvents.DeletingPage;
            DataFactory.Instance.DeletingPageLanguage += DataFactoryEvents.DeletingPageLanguage;

            //DataFactory.Instance.FailedLoadingChildren += DataFactoryEvents.FailedLoadingChildren;
            DataFactory.Instance.FailedLoadingContent += DataFactoryEvents.FailedLoadingContent;
            DataFactory.Instance.FailedLoadingPage += DataFactoryEvents.FailedLoadingPage;

            //DataFactory.Instance.FinishedLoadingChildren += DataFactoryEvents.FinishedLoadingChildren;
            DataFactory.Instance.FinishedLoadingPage += DataFactoryEvents.FinishedLoadingPage;

            //DataFactory.Instance.LoadedChildren += DataFactoryEvents.LoadedChildren;
            DataFactory.Instance.LoadedContent += DataFactoryEvents.LoadedContent;
            DataFactory.Instance.LoadedDefaultContent += DataFactoryEvents.LoadedDefaultContent;
            DataFactory.Instance.LoadedDefaultPageData += DataFactoryEvents.LoadedDefaultPageData;
            DataFactory.Instance.LoadedPage += DataFactoryEvents.LoadedPage;

            //DataFactory.Instance.LoadingChildren += DataFactoryEvents.LoadingChildren;
            DataFactory.Instance.LoadingContent += DataFactoryEvents.LoadingContent;
            DataFactory.Instance.LoadingDefaultContent += DataFactoryEvents.LoadingDefaultContent;
            DataFactory.Instance.LoadingDefaultPageData += DataFactoryEvents.LoadingDefaultPageData;
            DataFactory.Instance.LoadingPage += DataFactoryEvents.LoadingPage;

            DataFactory.Instance.MovedContent += DataFactoryEvents.MovedContent;
            DataFactory.Instance.MovedPage += DataFactoryEvents.MovedPage;
            DataFactory.Instance.MovingContent += DataFactoryEvents.MovingContent;
            DataFactory.Instance.MovingPage += DataFactoryEvents.MovingPage;

            DataFactory.Instance.PublishedContent += DataFactoryEvents.PublishedContent;
            DataFactory.Instance.PublishedPage += DataFactoryEvents.PublishedPage;

            DataFactory.Instance.PublishingContent += DataFactoryEvents.PublishingContent;
            DataFactory.Instance.PublishingPage += DataFactoryEvents.PublishingPage;

            DataFactory.Instance.SavedContent += DataFactoryEvents.SavedContent;
            DataFactory.Instance.SavedPage += DataFactoryEvents.SavedPage;
            DataFactory.Instance.SavingContent += DataFactoryEvents.SavingContent;
            DataFactory.Instance.SavingPage += DataFactoryEvents.SavingPage;
        }

        public void Preload(string[] parameters) { }

        public void Uninitialize(InitializationEngine context)
        {
            DataFactory.Instance.CheckedInContent -= DataFactoryEvents.CheckedInContent;
            DataFactory.Instance.CheckedInPage -= DataFactoryEvents.CheckedInPage;

            DataFactory.Instance.CheckingInContent -= DataFactoryEvents.CheckingInContent;
            DataFactory.Instance.CheckingInPage -= DataFactoryEvents.CheckingInPage;

            DataFactory.Instance.CreatedContent -= DataFactoryEvents.CreatedContent;
            DataFactory.Instance.CreatedPage -= DataFactoryEvents.CreatedPage;

            DataFactory.Instance.CreatingContent -= DataFactoryEvents.CreatingContent;
            DataFactory.Instance.CreatingPage -= DataFactoryEvents.CreatingPage;

            DataFactory.Instance.DeletedContent -= DataFactoryEvents.DeletedContent;
            DataFactory.Instance.DeletedContentLanguage -= DataFactoryEvents.DeletedContentLanguage;
            DataFactory.Instance.DeletedContentVersion -= DataFactoryEvents.DeletedContentVersion;
            DataFactory.Instance.DeletedPage -= DataFactoryEvents.DeletedPage;
            DataFactory.Instance.DeletedPageLanguage -= DataFactoryEvents.DeletedPageLanguage;

            DataFactory.Instance.DeletingContent -= DataFactoryEvents.DeletingContent;
            DataFactory.Instance.DeletingContentLanguage -= DataFactoryEvents.DeletingContentLanguage;
            DataFactory.Instance.DeletingContentVersion -= DataFactoryEvents.DeletingContentVersion;
            DataFactory.Instance.DeletingPage -= DataFactoryEvents.DeletingPage;
            DataFactory.Instance.DeletingPageLanguage -= DataFactoryEvents.DeletingPageLanguage;

            //DataFactory.Instance.FailedLoadingChildren -= DataFactoryEvents.FailedLoadingChildren;
            DataFactory.Instance.FailedLoadingContent -= DataFactoryEvents.FailedLoadingContent;
            DataFactory.Instance.FailedLoadingPage -= DataFactoryEvents.FailedLoadingPage;

            //DataFactory.Instance.FinishedLoadingChildren -= DataFactoryEvents.FinishedLoadingChildren;
            DataFactory.Instance.FinishedLoadingPage -= DataFactoryEvents.FinishedLoadingPage;

            //DataFactory.Instance.LoadedChildren -= DataFactoryEvents.LoadedChildren;
            DataFactory.Instance.LoadedContent -= DataFactoryEvents.LoadedContent;
            DataFactory.Instance.LoadedDefaultContent -= DataFactoryEvents.LoadedDefaultContent;
            DataFactory.Instance.LoadedDefaultPageData -= DataFactoryEvents.LoadedDefaultPageData;
            DataFactory.Instance.LoadedPage -= DataFactoryEvents.LoadedPage;

            //DataFactory.Instance.LoadingChildren -= DataFactoryEvents.LoadingChildren;
            DataFactory.Instance.LoadingContent -= DataFactoryEvents.LoadingContent;
            DataFactory.Instance.LoadingDefaultContent -= DataFactoryEvents.LoadingDefaultContent;
            DataFactory.Instance.LoadingDefaultPageData -= DataFactoryEvents.LoadingDefaultPageData;
            DataFactory.Instance.LoadingPage -= DataFactoryEvents.LoadingPage;

            DataFactory.Instance.MovedContent -= DataFactoryEvents.MovedContent;
            DataFactory.Instance.MovedPage -= DataFactoryEvents.MovedPage;
            DataFactory.Instance.MovingContent -= DataFactoryEvents.MovingContent;
            DataFactory.Instance.MovingPage -= DataFactoryEvents.MovingPage;

            DataFactory.Instance.PublishedContent -= DataFactoryEvents.PublishedContent;
            DataFactory.Instance.PublishedPage -= DataFactoryEvents.PublishedPage;

            DataFactory.Instance.PublishingContent -= DataFactoryEvents.PublishingContent;
            DataFactory.Instance.PublishingPage -= DataFactoryEvents.PublishingPage;

            DataFactory.Instance.SavedContent -= DataFactoryEvents.SavedContent;
            DataFactory.Instance.SavedPage -= DataFactoryEvents.SavedPage;
            DataFactory.Instance.SavingContent -= DataFactoryEvents.SavingContent;
            DataFactory.Instance.SavingPage -= DataFactoryEvents.SavingPage;
        }
    }
}