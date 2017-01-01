using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers.Content
{
    public static class DefaultContentLoad
    {
        public static void LoadingDefaultContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<ILoadingDefaultContent>(e => e.LoadingDefaultContent(sender, args));
        }

        public static void LoadedDefaultContent(object sender, ContentEventArgs args)
        {
            EventRunner.Execute<ILoadedDefaultContent>(e => e.LoadedDefaultContent(sender, args));
        }
    }
}