using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContentLanguage
    {
        void DeletingContentLanguage(object sender, ContentEventArgs e);
    }

    public abstract class DeletingContentLanguageBase<TContentType> : TypedEventBase<TContentType>, IDeletingContentLanguage
        where TContentType : IContent
    {
        public void DeletingContentLanguage(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            DeletingContentLanguage(sender, eventArgs);
        }

        public abstract void DeletingContentLanguage(object sender, TypedContentEventArgs e);
    }
}