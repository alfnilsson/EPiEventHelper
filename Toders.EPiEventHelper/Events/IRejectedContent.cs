using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IRejectedContent
    {
        void RejectedContent(object sender, ContentEventArgs args);
    }

    public abstract class RejectedContentBase<TContentType> : TypedEventBase<TContentType>, IRejectedContent
        where TContentType : IContent
    {
        public void RejectedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            RejectedContent(sender, eventArgs);
        }

        public abstract void RejectedContent(object sender, TypedContentEventArgs e);
    }
}