using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingChildren
    {
        void LoadingChildren(object sender, ChildrenEventArgs args);
    }
}