using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
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

        protected abstract void DeletingContentVersion(object sender, TypedContentEventArgs e);
    }
}