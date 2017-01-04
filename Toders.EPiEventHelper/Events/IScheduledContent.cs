using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IScheduledContent
    {
        void ScheduledContent(object sender, ContentEventArgs args);
    }

    public abstract class ScheduledContentBase<TContentType> : IScheduledContent
        where TContentType : IContent
    {
        public void ScheduledContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.ScheduledContent(sender, eventArgs);
        }

        public abstract void ScheduledContent(object sender, ContentEventArgs<TContentType> e);
    }
}