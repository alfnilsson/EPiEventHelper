using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class LoadedDefaultContentBase<TContentType> : TypedEventBase<TContentType>, ILoadedDefaultContent
        where TContentType : IContent
    {
        public void LoadedDefaultContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            LoadedDefaultContent(sender, eventArgs);
        }

        protected abstract void LoadedDefaultContent(object sender, TypedContentEventArgs e);
    }
}