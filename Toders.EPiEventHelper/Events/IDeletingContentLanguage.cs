using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IDeletingContentLanguage
    {
        void DeletingContentLanguage(object sender, ContentEventArgs e);
    }
}