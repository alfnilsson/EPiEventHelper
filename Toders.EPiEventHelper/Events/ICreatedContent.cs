using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatedContent
    {
        void CreatedContent(object sender, ContentEventArgs e);
    }

    public abstract class CreatedContentBase<TContentType> : TypedEventBase<TContentType>, ICreatedContent
        where TContentType : IContent
    {
        public void CreatedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CreatedContent(sender, eventArgs);
        }

        public abstract void CreatedContent(object sender, TypedContentEventArgs e);
    }
}