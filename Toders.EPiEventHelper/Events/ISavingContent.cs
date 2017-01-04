using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavingContent
    {
        void SavingContent(object sender, ContentEventArgs e);
    }

    public abstract class SavingContentBase<TContentType> : ISavingContent
        where TContentType : IContent
    {
        public void SavingContent(object sender, ContentEventArgs e)
        {
            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.SavingContent(sender, eventArgs);
        }

        public abstract void SavingContent(object sender, ContentEventArgs<TContentType> e);
    }
}