using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class CheckingInContentBase<TContentType> : TypedEventBase<TContentType>, ICheckingInContent
        where TContentType : IContent
    {
        public void CheckingInContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CheckingInContent(sender, eventArgs);
        }

        public abstract void CheckingInContent(object sender, TypedContentEventArgs e);
    }
}