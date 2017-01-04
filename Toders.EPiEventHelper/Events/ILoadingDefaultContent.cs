using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ILoadingDefaultContent
    {
        void LoadingDefaultContent(object sender, ContentEventArgs e);
    }

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