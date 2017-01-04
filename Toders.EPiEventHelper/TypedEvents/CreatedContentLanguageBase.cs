using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class CreatedContentLanguageBase<TContentType> : TypedEventBase<TContentType>, ICreatedContentLanguage
        where TContentType : IContent
    {
        public void CreatedContentLanguage(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CreatedContentLanguage(sender, eventArgs);
        }

        public abstract void CreatedContentLanguage(object sender, TypedContentEventArgs e);
    }
}