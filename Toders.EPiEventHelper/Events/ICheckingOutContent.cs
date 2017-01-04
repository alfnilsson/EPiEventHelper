using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckingOutContent
    {
        void CheckingOutContent(object sender, ContentEventArgs args);
    }

    public abstract class CheckingOutContentBase<TContentType> : TypedEventBase<TContentType>, ICheckingOutContent
        where TContentType : IContent
    {
        public void CheckingOutContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CheckingOutContent(sender, eventArgs);
        }

        public abstract void CheckingOutContent(object sender, TypedContentEventArgs e);
    }
}