using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IRequestedApproval
    {
        void RequestedApproval(object sender, ContentEventArgs args);
    }

    public abstract class RequestedApprovalBase<TContentType> : IRequestedApproval
        where TContentType : IContent
    {
        public void RequestedApproval(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.RequestedApproval(sender, eventArgs);
        }

        public abstract void RequestedApproval(object sender, ContentEventArgs<TContentType> e);
    }
}