using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CryV.Net.Helpers;

public class NativeTaskScheduler : TaskScheduler
{

    private readonly Thread _nativeThread;

    private readonly ConcurrentQueue<Task> _tasks = new ConcurrentQueue<Task>();

    public NativeTaskScheduler()
    {
        _nativeThread = Thread.CurrentThread;
    }

    protected override IEnumerable<Task> GetScheduledTasks()
    {
        return _tasks;
    }

    protected override void QueueTask(Task task)
    {
        _tasks.Enqueue(task);
    }

    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
    {
        if (Thread.CurrentThread != _nativeThread)
        {
            return false;
        }

        return TryExecuteTask(task);
    }

    internal void Tick()
    {
        var runs = _tasks.Count;

        while (runs-- > 0 && _tasks.TryDequeue(out var task))
        {
            TryExecuteTask(task);
        }
    }

}
