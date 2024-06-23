// ReSharper disable All
namespace Ds03_LinkedList;


public class LinkiListNode<T>
{
    public T Value { get; }
    public LinkiListNode<T>? Next { get; set; }
    
    public LinkiListNode(T value)
    {
        Value = value;
        Next = default;
    }

    public LinkiListNode(T value, LinkiListNode<T> next)
    {
        Value = value;
        Next = next;
    }
}

public class LinkiList<T>
{
    public LinkiListNode<T> Head { get; private set; }
    public LinkiListNode<T> Tail { get; private set; }
    public int Count { get; private set; } = 0;

    public LinkiList(T value)
    {
        var node = new LinkiListNode<T>(value);
        Head = node;
        Tail = node;
        Count++;
    }

    public void Prepend(LinkiListNode<T> node)
    {
        node.Next = Head;
        Head = node;
        Count++;
    }
    
    public void PrependWith(T value)
    {
        Prepend(new LinkiListNode<T>(value));
    }

    public void Append(LinkiListNode<T> node)
    {
        Tail.Next = node;
        Tail = Tail.Next;
        Count++;
    }

    public void AppendWith(T value)
    {
        Append(new LinkiListNode<T>(value));
    }

    public T? RemoveAt(int position)
    {
        if (position > Count)
            return default;

        if (position == 1 && Head.Next is not null)
        {
            var value = Head.Value;
            Head = Head.Next;
            Count--;
            return value;
        }
            

        var current = Head!;
        
        for (var runner = 1; runner < position; runner++)
        {
            current = current.Next!;
        }

        var toRemove = current.Next!;
        current.Next = toRemove.Next;
        Count--;

        return toRemove.Value;
    }
}