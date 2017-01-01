using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICheckedInContent
    {
        void CheckedInContent(object sender, ContentEventArgs e);
    }
}