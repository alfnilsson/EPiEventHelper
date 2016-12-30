using EPiServer;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.EventHandlers
{
    public static class Version
    {
        public static void DeletingContentVersion(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IDeletingContentVersion>(e => e.DeletingContentVersion(sender, eventArgs));
        }

        public static void DeletedContentVersion(object sender, ContentEventArgs eventArgs)
        {
            Runner.Run<IDeletedContentVersion>(e => e.DeletedContentVersion(sender, eventArgs));
        }
    }
}