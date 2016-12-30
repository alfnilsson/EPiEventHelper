using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class DefaultContentLoad
    {
        public static void LoadingDefaultContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ILoadingDefaultContent>(e => e.LoadingDefaultContent(sender, eventArgs));
        }

        public static void LoadedDefaultContent(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<ILoadedDefaultContent>(e => e.LoadedDefaultContent(sender, eventArgs));
        }
    }
}