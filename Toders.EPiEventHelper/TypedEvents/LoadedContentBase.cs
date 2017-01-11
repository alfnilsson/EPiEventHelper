using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class LoadedContentBase<TContentType> : TypedEventBase<TContentType>, ILoadedContent
        where TContentType : IContent
    {
        public void LoadedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            LoadedContent(sender, eventArgs);
        }

        protected abstract void LoadedContent(object sender, TypedContentEventArgs e);
    }
}