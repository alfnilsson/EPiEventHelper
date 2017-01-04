using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedContent
    {
        void LoadedContent(object sender, ContentEventArgs e);
    }

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

        public abstract void LoadedContent(object sender, TypedContentEventArgs e);
    }
}