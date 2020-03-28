using System;
using System.Threading;
using System.Threading.Tasks;

namespace CryV.Net.Helpers
{
    public static class ThreadHelper
    {

        private static Thread _mainThread;
        private static NativeTaskScheduler _nativeTaskScheduler;

        internal static void SetMainThread(Thread thread)
        {
            _mainThread = thread;

            _nativeTaskScheduler = new NativeTaskScheduler();
        }

        public static Task RunAsync(Action action)
        {
            if (Thread.CurrentThread == _mainThread)
            {
                try
                {
                    action();

                    return Task.CompletedTask;
                }
                catch (Exception exception)
                {
                    return Task.FromException(exception);
                }
            }

            return Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.DenyChildAttach, _nativeTaskScheduler);
        }

        public static Task<T> RunAsync<T>(Func<T> action)
        {
            if (Thread.CurrentThread == _mainThread)
            {
                try
                {
                    return Task.FromResult(action());
                }
                catch (Exception exception)
                {
                    return Task.FromException<T>(exception);
                }
            }

            return Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.DenyChildAttach, _nativeTaskScheduler);
        }

        public static void Work()
        {
            if (_nativeTaskScheduler == null)
            {
                _nativeTaskScheduler = new NativeTaskScheduler();
            }

            _nativeTaskScheduler.Tick();
        }

    }
}
