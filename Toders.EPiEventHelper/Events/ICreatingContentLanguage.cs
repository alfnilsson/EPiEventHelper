using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatingContentLanguage
    {
        void CreatingContentLanguage(object sender, ContentEventArgs args);
    }
}