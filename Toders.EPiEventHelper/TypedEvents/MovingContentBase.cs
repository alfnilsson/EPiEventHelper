using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class MovingContentBase<TContentType> : TypedEventBase<TContentType>, IMovingContent
        where TContentType : IContent
    {
        public void MovingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            MovingContent(sender, eventArgs);
        }

        protected abstract void MovingContent(object sender, TypedContentEventArgs e);
    }
}