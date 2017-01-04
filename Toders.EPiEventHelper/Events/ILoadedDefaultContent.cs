using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadedDefaultContent
    {
        void LoadedDefaultContent(object sender, ContentEventArgs e);
    }

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

        public abstract void LoadedDefaultContent(object sender, TypedContentEventArgs e);
    }
}