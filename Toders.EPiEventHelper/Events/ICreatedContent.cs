using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatedContent
    {
        void CreatedContent(object sender, ContentEventArgs e);
    }

    public abstract class CreatedContentBase<TContentType> : ICreatedContent
        where TContentType : IContent
    {
        public void CreatedContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.CreatedContent(sender, eventArgs);
        }

        public abstract void CreatedContent(object sender, ContentEventArgs<TContentType> e);
    }
}