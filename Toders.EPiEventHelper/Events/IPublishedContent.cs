using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishedContent
    {
        void PublishedContent(object sender, ContentEventArgs e);
    }

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

        public abstract void PublishedContent(object sender, TypedContentEventArgs e);
    }
}