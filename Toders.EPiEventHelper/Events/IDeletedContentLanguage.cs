using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedContentLanguage
    {
        void DeletedContentLanguage(object sender, ContentEventArgs e);
    }

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

        public abstract void DeletedContentLanguage(object sender, TypedContentEventArgs e);
    }
}