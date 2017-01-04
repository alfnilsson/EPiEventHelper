using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class MovedContentBase<TContentType> : TypedEventBase<TContentType>, IMovedContent
        where TContentType : IContent
    {
        public void MovedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            MovedContent(sender, eventArgs);
        }

        public abstract void MovedContent(object sender, TypedContentEventArgs e);
    }
}