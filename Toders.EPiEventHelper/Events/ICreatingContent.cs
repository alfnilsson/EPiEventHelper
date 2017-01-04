using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatingContent
    {
        void CreatingContent(object sender, ContentEventArgs e);
    }

    public abstract class CreatingContentBase<TContentType> : ICreatingContent
        where TContentType : IContent
    {
        public void CreatingContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CreatingContent(sender, eventArgs);
        }

        public abstract void CreatingContent(object sender, ContentEventArgs<TContentType> e);
    }
}