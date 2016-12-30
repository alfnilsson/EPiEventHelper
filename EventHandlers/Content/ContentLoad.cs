using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class ContentLoad
    {
        public static void LoadingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ILoadingContent>(e => e.LoadingContent(sender, eventArgs));
        }

        public static void LoadedContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ILoadedContent>(e => e.LoadedContent(sender, eventArgs));
        }

        public static void FailedLoadingContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IFailedLoadingContent>(e => e.FailedLoadingContent(sender, eventArgs));
        }
    }
}