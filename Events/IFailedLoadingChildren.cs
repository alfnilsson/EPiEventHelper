using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IFailedLoadingChildren
    {
        void FailedLoadingChildren(object sender, ChildrenEventArgs eventArgs);
    }
}