using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContentVersion
    {
        void DeletingContentVersion(object sender, ContentEventArgs e);
    }

    public abstract class DeletingContentVersionBase<TContentType> : IDeletingContentVersion
        where TContentType : IContent
    {
        public void DeletingContentVersion(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.DeletingContentVersion(sender, eventArgs);
        }

        public abstract void DeletingContentVersion(object sender, ContentEventArgs<TContentType> e);
    }
}