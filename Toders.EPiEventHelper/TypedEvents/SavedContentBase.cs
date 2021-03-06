﻿using EPiServer;
using EPiServer.Core;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class SavedContentBase<TContentType> : TypedEventBase<TContentType>, ISavedContent
        where TContentType : IContent
    {
        public void SavedContent(object sender, ContentEventArgs e)
        {
            if (AppliesTo(e.Content) == false)
            {
                return;
            }

            var eventArgs = new TypedContentEventArgs(e);
            SavedContent(sender, eventArgs);
        }

        protected abstract void SavedContent(object sender, TypedContentEventArgs e);
    }
}