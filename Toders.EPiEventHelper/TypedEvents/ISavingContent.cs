using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
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