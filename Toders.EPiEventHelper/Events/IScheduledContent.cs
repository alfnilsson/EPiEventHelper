using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IScheduledContent
    {
        void ScheduledContent(object sender, ContentEventArgs args);
    }

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

        public abstract void ScheduledContent(object sender, TypedContentEventArgs e);
    }
}