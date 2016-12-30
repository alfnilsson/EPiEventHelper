using EPiServer;

namespace Toders.EPiEventHelper.Events
{
    public interface IRequestedApproval
    {
        void RequestedApproval(object sender, ContentEventArgs eventArgs);
    }
}