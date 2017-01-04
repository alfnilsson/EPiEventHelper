using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IMovingContent
    {
        void MovingContent(object sender, ContentEventArgs e);
    }

    public abstract class MovingContentBase<TContentType> : TypedEventBase<TContentType>, IMovingContent
        where TContentType : IContent
    {
        public void MovingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            MovingContent(sender, eventArgs);
        }

        public abstract void MovingContent(object sender, TypedContentEventArgs e);
    }
}