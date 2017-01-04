using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatingContent
    {
        void CreatingContent(object sender, ContentEventArgs e);
    }

    public abstract class CreatingContentBase<TContentType> : TypedEventBase<TContentType>, ICreatingContent
        where TContentType : IContent
    {
        public void CreatingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CreatingContent(sender, eventArgs);
        }

        public abstract void CreatingContent(object sender, TypedContentEventArgs e);
    }
}