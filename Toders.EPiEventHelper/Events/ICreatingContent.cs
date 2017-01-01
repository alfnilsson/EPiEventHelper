using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatingContent
    {
        void CreatingContent(object sender, ContentEventArgs e);
    }
}