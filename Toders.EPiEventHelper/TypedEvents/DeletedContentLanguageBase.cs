using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class DeletedContentLanguageBase<TContentType> : TypedEventBase<TContentType>, IDeletedContentLanguage
        where TContentType : IContent
    {
        public void DeletedContentLanguage(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            DeletedContentLanguage(sender, eventArgs);
        }

        protected abstract void DeletedContentLanguage(object sender, TypedContentEventArgs e);
    }
}