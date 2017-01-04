using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishedContent
    {
        void PublishedContent(object sender, ContentEventArgs e);
    }

    public abstract class PublishedContentBase<TContentType> : IPublishedContent
        where TContentType : IContent
    {
        public void PublishedContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.PublishedContent(sender, eventArgs);
        }

        public abstract void PublishedContent(object sender, ContentEventArgs<TContentType> e);
    }
}