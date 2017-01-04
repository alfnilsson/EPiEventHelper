using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedDefaultContent
    {
        void LoadedDefaultContent(object sender, ContentEventArgs e);
    }

    public abstract class LoadedDefaultContentBase<TContentType> : ILoadedDefaultContent
        where TContentType : IContent
    {
        public void LoadedDefaultContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.LoadedDefaultContent(sender, eventArgs);
        }

        public abstract void LoadedDefaultContent(object sender, ContentEventArgs<TContentType> e);
    }
}