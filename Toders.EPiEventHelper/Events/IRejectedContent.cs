using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IRejectedContent
    {
        void RejectedContent(object sender, ContentEventArgs args);
    }

    public abstract class RejectedContentBase<TContentType> : IRejectedContent
        where TContentType : IContent
    {
        public void RejectedContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.RejectedContent(sender, eventArgs);
        }

        public abstract void RejectedContent(object sender, ContentEventArgs<TContentType> e);
    }
}