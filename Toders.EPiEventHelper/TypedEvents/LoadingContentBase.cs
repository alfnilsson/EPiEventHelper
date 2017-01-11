using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class LoadingContentBase<TContentType> : TypedEventBase<TContentType>, ILoadingContent
        where TContentType : IContent
    {
        public void LoadingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            LoadingContent(sender, eventArgs);
        }

        protected abstract void LoadingContent(object sender, TypedContentEventArgs e);
    }
}