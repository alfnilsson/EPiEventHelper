using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavingContent
    {
        void SavingContent(object sender, ContentEventArgs e);
    }

    public abstract class SavingContentBase<TContentType> : TypedEventBase<TContentType>, ISavingContent
        where TContentType : IContent
    {
        public void SavingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            SavingContent(sender, eventArgs);
        }

        public abstract void SavingContent(object sender, TypedContentEventArgs e);
    }
}