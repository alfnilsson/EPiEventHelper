using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ISchedulingContent
    {
        void SchedulingContent(object sender, ContentEventArgs args);
    }

    public abstract class SchedulingContentBase<TContentType> : ISchedulingContent
            where TContentType : IContent
    {
        public void SchedulingContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.SchedulingContent(sender, eventArgs);
        }

        public abstract void SchedulingContent(object sender, ContentEventArgs<TContentType> e);
    }
}