using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckingOutContent
    {
        void CheckingOutContent(object sender, ContentEventArgs args);
    }

    public abstract class CheckingOutContentBase<TContentType> : ICheckingOutContent
        where TContentType : IContent
    {
        public void CheckingOutContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CheckingOutContent(sender, eventArgs);
        }

        public abstract void CheckingOutContent(object sender, ContentEventArgs<TContentType> e);
    }
}