using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class RejectedContentBase<TContentType> : TypedEventBase<TContentType>, IRejectedContent
        where TContentType : IContent
    {
        public void RejectedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            RejectedContent(sender, eventArgs);
        }

        public abstract void RejectedContent(object sender, TypedContentEventArgs e);
    }
}