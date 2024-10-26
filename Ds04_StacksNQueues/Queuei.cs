namespace Ds04_StacksNQueues;

using System.Diagnostics.CodeAnalysis;

public class QueueItem<T>(T value) where T : struct
{
    public T Value { get; } = value;
    public QueueItem<T>? Next { get; set; } = default;
}


public class Queuei<T> where T : struct
{
    private QueueItem<T>? _head;
    private QueueItem<T>? _tail;
    
    public Queuei(T value)
    {
        var node = new QueueItem<T>(value);
        _head = _tail = node;
    }

    public void Enqueue(T value)
    {
        var node = new QueueItem<T>(value);
        if (_tail != null)
            _tail.Next = node;
         
        _tail = node; 
        _head ??= node;
    }

    public T? Dequeue()
    {
        var value = _head?.Value;
        if (_head != null)
            _head = _head.Next;

        if (_head == null)
            _tail = null;
        
        return value;
    }

    public T? Peek()
    {
        return _head?.Value;
    }
}