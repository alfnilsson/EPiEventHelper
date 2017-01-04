using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ISavingContent
    {
        void SavingContent(object sender, ContentEventArgs e);
    }
}