using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckedOutContent
    {
        void CheckedOutContent(object sender, ContentEventArgs args);
    }

    public abstract class CheckedOutContentBase<TContentType> : ICheckedOutContent
        where TContentType : IContent
    {
        public void CheckedOutContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CheckedOutContent(sender, eventArgs);
        }

        public abstract void CheckedOutContent(object sender, ContentEventArgs<TContentType> e);
    }
}