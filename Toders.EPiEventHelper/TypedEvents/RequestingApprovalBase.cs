using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class RequestingApprovalBase<TContentType> : TypedEventBase<TContentType>, IRequestingApproval
        where TContentType : IContent
    {
        public void RequestingApproval(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            RequestingApproval(sender, eventArgs);
        }

        protected abstract void RequestingApproval(object sender, TypedContentEventArgs e);
    }
}