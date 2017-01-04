using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingContent
    {
        void LoadingContent(object sender, ContentEventArgs e);
    }

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

        public abstract void LoadingContent(object sender, TypedContentEventArgs e);
    }
}