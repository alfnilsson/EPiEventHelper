using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishingContent
    {
        void PublishingContent(object sender, ContentEventArgs e);
    }

    public abstract class PublishingContentBase<TContentType> : TypedEventBase<TContentType>, IPublishingContent
        where TContentType : IContent
    {
        public void PublishingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            PublishingContent(sender, eventArgs);
        }

        public abstract void PublishingContent(object sender, TypedContentEventArgs e);
    }
}