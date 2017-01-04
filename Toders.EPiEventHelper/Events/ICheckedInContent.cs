using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckedInContent
    {
        void CheckedInContent(object sender, ContentEventArgs e);
    }

    public abstract class CheckedInContentBase<TContentType> : TypedEventBase<TContentType>, ICheckedInContent
        where TContentType : IContent
    {
        public void CheckedInContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CheckedInContent(sender, eventArgs);
        }

        public abstract void CheckedInContent(object sender, TypedContentEventArgs e);
    }
}