using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
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