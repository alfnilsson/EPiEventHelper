using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletedContentLanguage
    {
        void DeletedContentLanguage(object sender, ContentEventArgs e);
    }

    public abstract class DeletedContentLanguageBase<TContentType> : IDeletedContentLanguage
        where TContentType : IContent
    {
        public void DeletedContentLanguage(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.DeletedContentLanguage(sender, eventArgs);
        }

        public abstract void DeletedContentLanguage(object sender, ContentEventArgs<TContentType> e);
    }
}