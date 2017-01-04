using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavedContent
    {
        void SavedContent(object sender, ContentEventArgs e);
    }

    public abstract class SavedContentBase<TContentType> : ISavedContent
        where TContentType : IContent
    {
        public void SavedContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.SavedContent(sender, eventArgs);
        }

        public abstract void SavedContent(object sender, ContentEventArgs<TContentType> e);
    }
}