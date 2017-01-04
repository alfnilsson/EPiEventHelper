using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatedContentLanguage
    {
        void CreatedContentLanguage(object sender, ContentEventArgs args);
    }

    public abstract class CreatedContentLanguageBase<TContentType> : ICreatedContentLanguage
        where TContentType : IContent
    {
        public void CreatedContentLanguage(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CreatedContentLanguage(sender, eventArgs);
        }

        public abstract void CreatedContentLanguage(object sender, ContentEventArgs<TContentType> e);
    }
}