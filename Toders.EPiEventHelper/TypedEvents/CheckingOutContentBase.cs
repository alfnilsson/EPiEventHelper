using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class CheckingOutContentBase<TContentType> : TypedEventBase<TContentType>, ICheckingOutContent
        where TContentType : IContent
    {
        public void CheckingOutContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CheckingOutContent(sender, eventArgs);
        }

        protected abstract void CheckingOutContent(object sender, TypedContentEventArgs e);
    }
}