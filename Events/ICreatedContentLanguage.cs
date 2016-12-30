using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatedContentLanguage
    {
        void CreatedContentLanguage(object sender, ContentEventArgs eventArgs);
    }
}