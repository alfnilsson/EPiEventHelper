using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class RejectingContentBase<TContentType> : TypedEventBase<TContentType>, IRejectingContent
        where TContentType : IContent
    {
        public void RejectingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            RejectingContent(sender, eventArgs);
        }

        public abstract void RejectingContent(object sender, TypedContentEventArgs e);
    }
}