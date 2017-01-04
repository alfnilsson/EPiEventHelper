using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovingContent
    {
        void MovingContent(object sender, ContentEventArgs e);
    }

    public abstract class MovingContentBase<TContentType> : IMovingContent
        where TContentType : IContent
    {
        public void MovingContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.MovingContent(sender, eventArgs);
        }

        public abstract void MovingContent(object sender, ContentEventArgs<TContentType> e);
    }
}