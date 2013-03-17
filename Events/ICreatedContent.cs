using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface ICreatedContent
    {
        void CreatedContent(object sender, ContentEventArgs e);
    }
}