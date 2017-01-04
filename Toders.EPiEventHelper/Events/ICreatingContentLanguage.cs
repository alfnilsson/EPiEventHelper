using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatingContentLanguage
    {
        void CreatingContentLanguage(object sender, ContentEventArgs args);
    }

    public abstract class CreatingContentLanguageBase<TContentType> : TypedEventBase<TContentType>, ICreatingContentLanguage
        where TContentType : IContent
    {
        public void CreatingContentLanguage(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            CreatingContentLanguage(sender, eventArgs);
        }

        public abstract void CreatingContentLanguage(object sender, TypedContentEventArgs e);
    }
}