using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class PublishedContentBase<TContentType> : TypedEventBase<TContentType>, IPublishedContent
        where TContentType : IContent
    {
        public void PublishedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            PublishedContent(sender, eventArgs);
        }

        protected abstract void PublishedContent(object sender, TypedContentEventArgs e);
    }
}