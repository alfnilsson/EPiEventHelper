using EPiServer;
using EPiServer.Core;

namespace Toders.EPiEventHelper.Events
{
    public interface IPublishingContent
    {
        void PublishingContent(object sender, ContentEventArgs e);
    }

    public abstract class PublishingContentBase<TContentType> : IPublishingContent
        where TContentType : IContent
    {
        /// <summary>
        /// Gets whether the specified content must be same Content Type as TContentType or can inherit of
        /// </summary>
        protected virtual bool AllowInheritance { get { return false; } }

        public void PublishingContent(object sender, ContentEventArgs e)
        {
            bool allowInheritance = AllowInheritance;
            if (allowInheritance
                && e.Content is TContentType == false)
            {
                return;
            }

            if (allowInheritance == false
                && e.Content.GetOriginalType() != typeof(TContentType))
            {
                return;
            }

            var eventArgs = new ContentEventArgs<TContentType>(e);
            this.PublishingContent(sender, eventArgs);
        }

        public abstract void PublishingContent(object sender, ContentEventArgs<TContentType> e);
    }
}