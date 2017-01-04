using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckingInContent
    {
        void CheckingInContent(object sender, ContentEventArgs e);
    }

    public abstract class CheckingInContentBase<TContentType> : ICheckingInContent
        where TContentType : IContent
    {
        public void CheckingInContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CheckingInContent(sender, eventArgs);
        }

        public abstract void CheckingInContent(object sender, ContentEventArgs<TContentType> e);
    }
}