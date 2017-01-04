using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContentLanguage
    {
        void DeletingContentLanguage(object sender, ContentEventArgs e);
    }

    public abstract class DeletingContentLanguageBase<TContentType> : IDeletingContentLanguage
        where TContentType : IContent
    {
        public void DeletingContentLanguage(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.DeletingContentLanguage(sender, eventArgs);
        }

        public abstract void DeletingContentLanguage(object sender, ContentEventArgs<TContentType> e);
    }
}