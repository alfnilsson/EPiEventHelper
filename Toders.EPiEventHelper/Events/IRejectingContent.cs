using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IRejectingContent
    {
        void RejectingContent(object sender, ContentEventArgs args);
    }

    public abstract class RejectingContentBase<TContentType> : IRejectingContent
        where TContentType : IContent
    {
        public void RejectingContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.RejectingContent(sender, eventArgs);
        }

        public abstract void RejectingContent(object sender, ContentEventArgs<TContentType> e);
    }
}