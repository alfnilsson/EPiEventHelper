using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentLoad
    {
        public static void LoadingContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<ILoadingContent>(e => e.LoadingContent(sender, args));
        }

        public static void LoadedContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<ILoadedContent>(e => e.LoadedContent(sender, args));
        }

        public static void FailedLoadingContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<IFailedLoadingContent>(e => e.FailedLoadingContent(sender, args));
        }
    }
}