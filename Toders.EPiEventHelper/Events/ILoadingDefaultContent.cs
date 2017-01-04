using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingDefaultContent
    {
        void LoadingDefaultContent(object sender, ContentEventArgs e);
    }

    public abstract class LoadingDefaultContentBase<TContentType> : ILoadingDefaultContent
            where TContentType : IContent
    {
        public void LoadingDefaultContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.LoadingDefaultContent(sender, eventArgs);
        }

        public abstract void LoadingDefaultContent(object sender, ContentEventArgs<TContentType> e);
    }
}