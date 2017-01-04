using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class SchedulingContentBase<TContentType> : TypedEventBase<TContentType>, ISchedulingContent
            where TContentType : IContent
    {
        public void SchedulingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            SchedulingContent(sender, eventArgs);
        }

        public abstract void SchedulingContent(object sender, TypedContentEventArgs e);
    }
}