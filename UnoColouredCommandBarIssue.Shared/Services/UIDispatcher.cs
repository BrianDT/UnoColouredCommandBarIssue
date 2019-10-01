// <copyright file="UIDispatcher.cs" company="Visual Software Systems Ltd.">Copyright (c) 2013 All rights reserved</copyright>

namespace TwistedFish.Echo.Mobile_UWP.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TwistedFish.Echo.Platform.Common;
    using Windows.UI.Core;
    using Windows.UI.Xaml;

    public class UIDispatcher : IDispatchOnUIThread
    {
        private static CoreDispatcher dispatcher;

        /// <summary>
        /// Gets the dispatcher
        /// </summary>
        public static CoreDispatcher Dispatcher
        {
            get
            {
                return dispatcher;
            }
        }

        /// <summary>
        /// Initialise the dispatcher
        /// </summary>
        public static void Initialize()
        {
            if (Window.Current != null)
            {
                UIDispatcher.dispatcher = Windows.UI.Xaml.Window.Current.Dispatcher;
            }
        }

        public void Invoke(Action action)
        {
            var task = UIDispatcher.Execute(action);
        }

        /// <summary>
        /// Execute an action via the dispatcher
        /// </summary>
        /// <param name="action">The action</param>
        public static void ExecuteNoWait(Action action, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal)
        {
            if (delayms > 0)
            {
                Task.Delay(delayms).ConfigureAwait(dispatcher.HasThreadAccess).GetAwaiter().GetResult();
            }

            if (UIDispatcher.dispatcher == null || (UIDispatcher.dispatcher.HasThreadAccess && priority == CoreDispatcherPriority.Normal))
            {
                action();
            }
            else
            {
                // Not awated execution will continue before the action has completed
                UIDispatcher.dispatcher.RunAsync(priority, () => action()).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
        }

        /// <summary>
        /// Execute an action via the dispatcher
        /// </summary>
        /// <param name="action">The action</param>
        /// <param name="delayms">Any delay before the execution</param>
        /// <param name="priority">The priority</param>
        public static async Task Execute(Action action, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal)
        {
            if (delayms > 0)
            {
                await Task.Delay(delayms).ConfigureAwait(dispatcher.HasThreadAccess);
            }

            if (UIDispatcher.dispatcher == null || (UIDispatcher.dispatcher.HasThreadAccess && priority == CoreDispatcherPriority.Normal))
            {
                action();
            }
            else
            {
                var tcs = new TaskCompletionSource<object>();

                await dispatcher.RunAsync(priority, () =>
                {
                    try
                    {
                        action();
                        tcs.TrySetResult(null);
                    }
                    catch (Exception ex)
                    {
                        tcs.TrySetException(ex);
                    }
                }).AsTask().ConfigureAwait(false);
                await tcs.Task.ConfigureAwait(false);
            }
        }
    }
}
