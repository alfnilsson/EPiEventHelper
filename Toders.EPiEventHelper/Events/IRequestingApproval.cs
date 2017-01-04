using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IRequestingApproval
    {
        void RequestingApproval(object sender, ContentEventArgs args);
    }

    public abstract class RequestingApprovalBase<TContentType> : IRequestingApproval
        where TContentType : IContent
    {
        public void RequestingApproval(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.RequestingApproval(sender, eventArgs);
        }

        public abstract void RequestingApproval(object sender, ContentEventArgs<TContentType> e);
    }
}