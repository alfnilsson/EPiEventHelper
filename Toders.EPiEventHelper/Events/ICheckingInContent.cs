using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckingInContent
    {
        void CheckingInContent(object sender, ContentEventArgs e);
    }

    public abstract class CheckingInContentBase<TContentType> : TypedEventBase<TContentType>, ICheckingInContent
        where TContentType : IContent
    {
        public void CheckingInContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CheckingInContent(sender, eventArgs);
        }

        public abstract void CheckingInContent(object sender, TypedContentEventArgs e);
    }
}