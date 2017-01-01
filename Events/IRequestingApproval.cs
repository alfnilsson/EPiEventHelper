using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IRequestingApproval
    {
        void RequestingApproval(object sender, ContentEventArgs args);
    }
}