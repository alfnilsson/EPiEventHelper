using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedContentVersion
    {
        void DeletedContentVersion(object sender, ContentEventArgs e);
    }

    public abstract class DeletedContentVersionBase<TContentType> : IDeletedContentVersion
        where TContentType : IContent
    {
        public void DeletedContentVersion(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.DeletedContentVersion(sender, eventArgs);
        }

        public abstract void DeletedContentVersion(object sender, ContentEventArgs<TContentType> e);
    }
}