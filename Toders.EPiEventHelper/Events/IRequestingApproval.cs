using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IRequestingApproval
    {
        void RequestingApproval(object sender, ContentEventArgs args);
    }

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

        public abstract void RequestingApproval(object sender, TypedContentEventArgs e);
    }
}