using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedContentVersion
    {
        void DeletedContentVersion(object sender, ContentEventArgs e);
    }

    public abstract class DeletedContentVersionBase<TContentType> : TypedEventBase<TContentType>, IDeletedContentVersion
        where TContentType : IContent
    {
        public void DeletedContentVersion(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            DeletedContentVersion(sender, eventArgs);
        }

        public abstract void DeletedContentVersion(object sender, TypedContentEventArgs e);
    }
}