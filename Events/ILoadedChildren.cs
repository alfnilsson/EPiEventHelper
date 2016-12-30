using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedChildren
    {
        void LoadedChildren(object sender, ChildrenEventArgs eventArgs);
    }
}