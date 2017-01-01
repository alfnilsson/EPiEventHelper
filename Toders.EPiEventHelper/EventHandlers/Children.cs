using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers
{
    public class Children
    {
        private readonly IEventRunner _eventRunner;

        public Children(IEventRunner eventRunner)
        {
            _eventRunner = eventRunner;
        }

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
    }
}