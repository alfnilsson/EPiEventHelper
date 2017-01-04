using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovedContent
    {
        void MovedContent(object sender, ContentEventArgs e);
    }

    public abstract class MovedContentBase<TContentType> : IMovedContent
        where TContentType : IContent
    {
        public void MovedContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.MovedContent(sender, eventArgs);
        }

        public abstract void MovedContent(object sender, ContentEventArgs<TContentType> e);
    }
}