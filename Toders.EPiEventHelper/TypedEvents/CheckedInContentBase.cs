using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class CheckedInContentBase<TContentType> : TypedEventBase<TContentType>, ICheckedInContent
        where TContentType : IContent
    {
        public void CheckedInContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CheckedInContent(sender, eventArgs);
        }

        protected abstract void CheckedInContent(object sender, TypedContentEventArgs e);
    }
}