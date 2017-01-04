using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContentVersion
    {
        void DeletingContentVersion(object sender, ContentEventArgs e);
    }

    public abstract class DeletingContentVersionBase<TContentType> : TypedEventBase<TContentType>, IDeletingContentVersion
        where TContentType : IContent
    {
        public void DeletingContentVersion(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            DeletingContentVersion(sender, eventArgs);
        }

        public abstract void DeletingContentVersion(object sender, TypedContentEventArgs e);
    }
}