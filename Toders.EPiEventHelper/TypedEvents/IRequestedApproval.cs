using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class RequestedApprovalBase<TContentType> : TypedEventBase<TContentType>, IRequestedApproval
        where TContentType : IContent
    {
        public void RequestedApproval(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            RequestedApproval(sender, eventArgs);
        }

        public abstract void RequestedApproval(object sender, TypedContentEventArgs e);
    }
}