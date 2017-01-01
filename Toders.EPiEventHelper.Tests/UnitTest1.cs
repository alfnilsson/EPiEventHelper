using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Toders.EPiEventHelper.EventHandlers;
using Toders.EPiEventHelper.Events;

namespace Toders.EPiEventHelper.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThereShouldBeAnInterfaceForEachEvent()
        {
            var type = typeof(IContentEvents);
            var events = type.GetEvents();

            foreach (var eventInfo in events)
            {
                Debug.WriteLine(eventInfo.Name);
                var eventHandler = Type.GetType("Toders.EPiEventHelper.Events.I" + eventInfo.Name + ", Toders.EPiEventHelper");
                Assert.IsNotNull(eventHandler);
            }
        }

        [TestMethod]
        public void EventBindingAndUnbinding()
        {
            var eventsToTest = new Dictionary<Type, Expression<Action>>();
            List<string> triggeredEvents = new List<string>();

            var contentEvents = new FakeContentEvents();
            Mock<IServiceLocator> serviceLocatorMock = new Mock<IServiceLocator>();

            var mockedSender = It.IsAny<object>();
            var mockedContentEventArgs = It.IsAny<ContentEventArgs>();
            var mockedDeletedContentEventArgs = It.IsAny<DeleteContentEventArgs>();
            var mockedChildrenEventArgs = It.IsAny<ChildrenEventArgs>();

            var testModel = new TestModel
            {
                ServiceLocatorMock = serviceLocatorMock,
                EventsToTest = eventsToTest,
                TriggeredEvents = triggeredEvents,
            };

            Setup<ICreatingContent>(
                i => i.CreatingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCreatingContent(),
                testModel);

            Setup<ICreatedContent>(
                i => i.CreatedContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCreatedContent(),
                testModel);

            Setup<ISavingContent>(
                i => i.SavingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnSavingContent(),
                testModel);

            Setup<ISavedContent>(
                i => i.SavedContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnSavedContent(),
                testModel);

            Setup<ICheckingInContent>(
                i => i.CheckingInContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCheckingInContent(),
                testModel);

            Setup<ICheckedInContent>(
                i => i.CheckedInContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCheckedInContent(),
                testModel);

            Setup<ICheckingOutContent>(
                i => i.CheckingOutContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCheckingOutContent(),
                testModel);

            Setup<ICheckedOutContent>(
                i => i.CheckedOutContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCheckedOutContent(),
                testModel);

            Setup<IRejectingContent>(
                i => i.RejectingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnRejectingContent(),
                testModel);

            Setup<IRejectedContent>(
                i => i.RejectedContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnRejectedContent(),
                testModel);

            Setup<IRequestingApproval>(
                i => i.RequestingApproval(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnRequestingApproval(),
                testModel);

            Setup<IRequestedApproval>(
                i => i.RequestedApproval(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnRequestedApproval(),
                testModel);

            Setup<IPublishingContent>(
                i => i.PublishingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnPublishingContent(),
                testModel);

            Setup<IPublishedContent>(
                i => i.PublishedContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnPublishedContent(),
                testModel);

            Setup<IMovingContent>(
                i => i.MovingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnMovingContent(),
                testModel);

            Setup<IMovedContent>(
                i => i.MovedContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnMovedContent(),
                testModel);

            Setup<IDeletingContent>(
                i => i.DeletingContent(mockedSender, mockedDeletedContentEventArgs),
                () => contentEvents.OnDeletingContent(),
                testModel);

            Setup<IDeletedContent>(
                i => i.DeletedContent(mockedSender, mockedDeletedContentEventArgs),
                () => contentEvents.OnDeletedContent(),
                testModel);

            Setup<ILoadingContent>(
                i => i.LoadingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnLoadingContent(),
                testModel);

            Setup<ILoadedContent>(
                i => i.LoadedContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnLoadedContent(),
                testModel);

            Setup<IFailedLoadingContent>(
                i => i.FailedLoadingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnFailedLoadingContent(),
                testModel);

            Setup<ISchedulingContent>(
                i => i.SchedulingContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnSchedulingContent(),
                testModel);

            Setup<IScheduledContent>(
                i => i.ScheduledContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnScheduledContent(),
                testModel);

            Setup<ILoadingDefaultContent>(
                i => i.LoadingDefaultContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnLoadingDefaultContent(),
                testModel);

            Setup<ILoadedDefaultContent>(
                i => i.LoadedDefaultContent(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnLoadedDefaultContent(),
                testModel);

            Setup<ICreatingContentLanguage>(
                i => i.CreatingContentLanguage(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCreatingContentLanguage(),
                testModel);

            Setup<ICreatedContentLanguage>(
                i => i.CreatedContentLanguage(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnCreatedContentLanguage(),
                testModel);

            Setup<IDeletingContentLanguage>(
                i => i.DeletingContentLanguage(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnDeletingContentLanguage(),
                testModel);

            Setup<IDeletedContentLanguage>(
                i => i.DeletedContentLanguage(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnDeletedContentLanguage(),
                testModel);

            Setup<IDeletingContentVersion>(
                i => i.DeletingContentVersion(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnDeletingContentVersion(),
                testModel);

            Setup<IDeletedContentVersion>(
                i => i.DeletedContentVersion(mockedSender, mockedContentEventArgs),
                () => contentEvents.OnDeletedContentVersion(),
                testModel);

            Setup<ILoadingChildren>(
                i => i.LoadingChildren(mockedSender, mockedChildrenEventArgs),
                () => contentEvents.OnLoadingChildren(),
                testModel);

            Setup<ILoadedChildren>(
                i => i.LoadedChildren(mockedSender, mockedChildrenEventArgs),
                () => contentEvents.OnLoadedChildren(),
                testModel);

            var binder = new EventBinder(
                contentEvents,
                new EventRunner(serviceLocatorMock.Object));

            Debug.WriteLine("Binding");

            binder.BindEvents();

            foreach (var eventToTest in eventsToTest)
            {
                triggeredEvents.Clear();
                var eventName = eventToTest.Value.Body.ToString().Split(new[] { '.' }).Last();
                Debug.WriteLine("Running " + eventName + " should only add " + eventToTest.Key.Name);
                eventToTest.Value.Compile()();

                Assert.AreEqual(1, triggeredEvents.Count);
                Assert.AreEqual(eventToTest.Key.FullName, triggeredEvents.First());
            }

            Debug.WriteLine("Unbinding");

            triggeredEvents.Clear();
            binder.UnbindEvents();

            foreach (var t in eventsToTest)
            {
                t.Value.Compile()();
                Assert.AreEqual(0, triggeredEvents.Count);
            }
        }

        private static void Setup<T>(
            Expression<Action<T>> expression,
            Expression<Action> eventToTest,
            TestModel model)
            where T : class
        {
            var serviceLocatorMock = model.ServiceLocatorMock;
            var triggeredEvents = model.TriggeredEvents;
            var eventsToTest = model.EventsToTest;

            serviceLocatorMock.Setup(x => x.GetAllInstances<T>())
                .Returns(() =>
                {
                    var mock = new Mock<T>();
                    mock.Setup(expression)
                        .Callback(() =>
                        {
                            triggeredEvents.Add(typeof(T).FullName);
                        });
                    return new[] { mock.Object };
                });
            Debug.WriteLine("Adding " + typeof(T).FullName);
            eventsToTest.Add(typeof(T), eventToTest);
        }

        private class TestModel
        {
            public Mock<IServiceLocator> ServiceLocatorMock { get; set; }
            public List<string> TriggeredEvents { get; set; }
            public Dictionary<Type, Expression<Action>> EventsToTest { get; set; }
        }
    }
}
