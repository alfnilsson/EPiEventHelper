﻿using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class PublishingContentBase<TContentType> : TypedEventBase<TContentType>, IPublishingContent
        where TContentType : IContent
    {
        public void PublishingContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            PublishingContent(sender, eventArgs);
        }

        protected abstract void PublishingContent(object sender, TypedContentEventArgs e);
    }
}