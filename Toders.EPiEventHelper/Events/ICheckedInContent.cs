using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckedInContent
    {
        void CheckedInContent(object sender, ContentEventArgs e);
    }

    public abstract class CheckedInContentBase<TContentType> : ICheckedInContent
        where TContentType : IContent
    {
        public void CheckedInContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CheckedInContent(sender, eventArgs);
        }

        public abstract void CheckedInContent(object sender, ContentEventArgs<TContentType> e);
    }
}