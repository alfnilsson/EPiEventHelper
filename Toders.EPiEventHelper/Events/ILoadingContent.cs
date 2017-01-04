using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingContent
    {
        void LoadingContent(object sender, ContentEventArgs e);
    }

    public abstract class LoadingContentBase<TContentType> : ILoadingContent
        where TContentType : IContent
    {
        public void LoadingContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.LoadingContent(sender, eventArgs);
        }

        public abstract void LoadingContent(object sender, ContentEventArgs<TContentType> e);
    }
}