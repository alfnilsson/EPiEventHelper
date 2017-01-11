using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class CreatingContentLanguageBase<TContentType> : TypedEventBase<TContentType>, ICreatingContentLanguage
        where TContentType : IContent
    {
        public void CreatingContentLanguage(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CreatingContentLanguage(sender, eventArgs);
        }

        protected abstract void CreatingContentLanguage(object sender, TypedContentEventArgs e);
    }
}