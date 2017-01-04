using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class FailedLoadingContentBase<TContentType> : TypedEventBase<TContentType>, IFailedLoadingContent
        where TContentType : IContent
    {
        public void FailedLoadingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            FailedLoadingContent(sender, eventArgs);
        }

        public abstract void FailedLoadingContent(object sender, TypedContentEventArgs e);
    }
}