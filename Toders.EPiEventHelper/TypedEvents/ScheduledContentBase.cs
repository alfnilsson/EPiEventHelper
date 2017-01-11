using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class ScheduledContentBase<TContentType> : TypedEventBase<TContentType>, IScheduledContent
        where TContentType : IContent
    {
        public void ScheduledContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            ScheduledContent(sender, eventArgs);
        }

        protected abstract void ScheduledContent(object sender, TypedContentEventArgs e);
    }
}