using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers
{
    public static class Children
    {
        public static void LoadingChildren(object sender, ChildrenEventArgs eventArgs)
        {
            Runner.Run<ILoadingChildren>(e => e.LoadingChildren(sender, eventArgs));
        }

        public static void LoadedChildren(object sender, ChildrenEventArgs eventArgs)
        {
            Runner.Run<ILoadedChildren>(e => e.LoadedChildren(sender, eventArgs));
        }

        public static void FailedLoadingChildren(object sender, ChildrenEventArgs eventArgs)
        {
            Runner.Run<IFailedLoadingChildren>(e => e.FailedLoadingChildren(sender, eventArgs));
        }
    }
}