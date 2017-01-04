using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class LoadingDefaultContentBase<TContentType> : TypedEventBase<TContentType>, ILoadingDefaultContent
            where TContentType : IContent
    {
        public void LoadingDefaultContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            LoadingDefaultContent(sender, eventArgs);
        }

        public abstract void LoadingDefaultContent(object sender, TypedContentEventArgs e);
    }
}