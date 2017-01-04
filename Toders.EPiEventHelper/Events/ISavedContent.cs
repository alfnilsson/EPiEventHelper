using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavedContent
    {
        void SavedContent(object sender, ContentEventArgs e);
    }

    public abstract class SavedContentBase<TContentType> : TypedEventBase<TContentType>, ISavedContent
        where TContentType : IContent
    {
        public void SavedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            SavedContent(sender, eventArgs);
        }

        public abstract void SavedContent(object sender, TypedContentEventArgs e);
    }
}