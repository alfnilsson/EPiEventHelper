using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IFailedLoadingContent
    {
        void FailedLoadingContent(object sender, ContentEventArgs e);
    }

    public abstract class FailedLoadingContentBase<TContentType> : IFailedLoadingContent
        where TContentType : IContent
    {
        public void FailedLoadingContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.FailedLoadingContent(sender, eventArgs);
        }

        public abstract void FailedLoadingContent(object sender, ContentEventArgs<TContentType> e);
    }
}