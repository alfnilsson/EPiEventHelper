using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedContent
    {
        void LoadedContent(object sender, ContentEventArgs e);
    }

    public abstract class LoadedContentBase<TContentType> : ILoadedContent
        where TContentType : IContent
    {
        public void LoadedContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.LoadedContent(sender, eventArgs);
        }

        public abstract void LoadedContent(object sender, ContentEventArgs<TContentType> e);
    }
}