using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class CheckedOutContentBase<TContentType> : TypedEventBase<TContentType>, ICheckedOutContent
        where TContentType : IContent
    {
        public void CheckedOutContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CheckedOutContent(sender, eventArgs);
        }

        public abstract void CheckedOutContent(object sender, TypedContentEventArgs e);
    }
}