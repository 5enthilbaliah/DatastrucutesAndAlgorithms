namespace Ds04_StacksNQueues;

public class StackItem<T>(T value) where T : struct
{
    public T Value { get; } = value;
    public StackItem<T>? Next { get; init; } = default;
}

public class Stacki<T> where T : struct
{
    private StackItem<T>? _head;
    
    public Stacki(T value)
    {
        var node = new StackItem<T>(value);
        _head = node;
    }

    public void Push(T value)
    {
        var node = new StackItem<T>(value)
        {
            Next = _head
        };
        _head = node;
    }

    public T? Pop()
    {
        var node = _head;
        _head = node?.Next;
        return node?.Value;
    }

    public T? Peek()
    {
        return _head?.Value;
    }
}