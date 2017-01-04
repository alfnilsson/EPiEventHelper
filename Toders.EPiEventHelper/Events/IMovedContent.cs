using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovedContent
    {
        void MovedContent(object sender, ContentEventArgs e);
    }

    public abstract class MovedContentBase<TContentType> : TypedEventBase<TContentType>, IMovedContent
        where TContentType : IContent
    {
        public void MovedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            MovedContent(sender, eventArgs);
        }

        public abstract void MovedContent(object sender, TypedContentEventArgs e);
    }
}