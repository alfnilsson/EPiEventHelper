using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatingContentLanguage
    {
        void CreatingContentLanguage(object sender, ContentEventArgs args);
    }

    public abstract class CreatingContentLanguageBase<TContentType> : ICreatingContentLanguage
        where TContentType : IContent
    {
        public void CreatingContentLanguage(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CreatingContentLanguage(sender, eventArgs);
        }

        public abstract void CreatingContentLanguage(object sender, ContentEventArgs<TContentType> e);
    }
}