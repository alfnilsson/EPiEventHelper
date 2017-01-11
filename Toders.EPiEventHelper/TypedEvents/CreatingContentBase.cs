using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class CreatingContentBase<TContentType> : TypedEventBase<TContentType>, ICreatingContent
        where TContentType : IContent
    {
        public void CreatingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CreatingContent(sender, eventArgs);
        }

        protected abstract void CreatingContent(object sender, TypedContentEventArgs e);
    }
}