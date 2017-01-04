using System.Collections;
using EPiServer;
using EPiServer.Core;
using EPiServer.Security;

namespace Toders.EPiEventHelper.TypedEvents
{
    public abstract class TypedEventBase<TContentType>
        where TContentType : IContent
    {
        /// <summary>
        /// Gets whether the specified content must be same Content Type as TContentType or can inherit of
        /// </summary>
        protected virtual bool AllowInheritance { get { return false; } }

        protected bool AppliesTo(IContent content)
        {
            bool allowInheritance = AllowInheritance;
            if (allowInheritance
                && content is TContentType == false)
            {
                return false;
            }

            if (allowInheritance == false
                && content.GetOriginalType() != typeof(TContentType))
            {
                return false;
            }

            return true;
        }

        public class TypedContentEventArgs
        {
            private readonly ContentEventArgs _originalEventArgs;

            public TypedContentEventArgs(ContentEventArgs originalEventArgs)
            {
                _originalEventArgs = originalEventArgs;
            }

            public TContentType Content
            {
                get { return (TContentType)_originalEventArgs.Content; }
                set { _originalEventArgs.Content = value; }
            }

            public bool CancelAction
            {
                get { return _originalEventArgs.CancelAction; }
                set { _originalEventArgs.CancelAction = value; }
            }

            public string CancelReason
            {
                get { return _originalEventArgs.CancelReason; }
                set { _originalEventArgs.CancelReason = value; }
            }

            public ContentReference ContentLink
            {
                get { return _originalEventArgs.ContentLink; }
                set { _originalEventArgs.ContentLink = value; }
            }

            public object Creator
            {
                get { return _originalEventArgs.Creator; }
                set { _originalEventArgs.Creator = value; }
            }

            public IDictionary Items
            {
                get { return _originalEventArgs.Items; }
            }

            public AccessLevel RequiredAccess
            {
                get { return _originalEventArgs.RequiredAccess; }
                set { _originalEventArgs.RequiredAccess = value; }
            }

            public ContentReference TargetLink
            {
                get { return _originalEventArgs.TargetLink; }
                set { _originalEventArgs.TargetLink = value; }
            }
        }
    }
}