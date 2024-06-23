namespace Ds03_LinkedList;

using System.Text;

public class DoublyLinkiListNode<T>
{
    public DoublyLinkiListNode<T>? Prev { get; set; }
    public T Value { get; set; }
    public DoublyLinkiListNode<T>? Next { get; set; }
    
    public DoublyLinkiListNode(T value)
    {
        Prev = default;
        Value = value;
        Next = default;
    }
}

public class DoublyLinkiList<T>
{
    public DoublyLinkiListNode<T> Head { get; private set; }
    public DoublyLinkiListNode<T> Tail { get; private set; }
    public int Count { get; private set; } = 0;

    public DoublyLinkiList(T value)
    {
        var node = new DoublyLinkiListNode<T>(value);
        Head = node;
        Tail = node;
        Count++;
    }
    
    private DoublyLinkiListNode<T> TraverseTo(int position)
    {
        var current = Head!;
        for (var runner = 1; runner < position; runner++)
        {
            current = current.Next!;
        }

        return current;
    }
    
    private DoublyLinkiListNode<T> ReverseTraverseTo(int position)
    {
        var current = Tail!;
        for (var runner = 1; runner < Count - position; runner++)
        {
            current = current.Prev!;
        }

        return current;
    }
    
    public T LookUp(int position)
    {
        var current = TraverseTo(position);
        return current.Value;
    }
    
    public void Prepend(DoublyLinkiListNode<T> node)
    {
        node.Next = Head;
        Head.Prev = node;
        Head = node;
        Count++;
    }
    
    public void PrependWith(T value)
    {
        Prepend(new DoublyLinkiListNode<T>(value));
    }
    
    public void Append(DoublyLinkiListNode<T> node)
    {
        Tail.Next = node;
        node.Prev = Tail;
        Tail = Tail.Next;
        Count++;
    }

    public void AppendWith(T value)
    {
        Append(new DoublyLinkiListNode<T>(value));
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

            if (Count == 1)
            {
                Tail = Head;
            }
            
            return value;
        }

        var current = TraverseTo(position);
        var toRemove = current.Next!;
        var next = toRemove.Next!;
        current.Next = next;
        if (next is not null)
            next.Prev = current;

        Count--;

        if (Count == position)
        {
            Tail = current;
        }
        
        if (Count == 1)
        {
            Tail = Head;
        }

        return toRemove.Value;
    }
    
    public void InsertAt(int position, T value)
    {
        if (position <= 1)
        {
            PrependWith(value);
            return;
        }

        if (position >= Count + 1)
        {
            AppendWith(value);
            return;
        }
        
        var current = TraverseTo(position);
        var toAdd = new DoublyLinkiListNode<T>(value);
        var next =  current.Next;
        toAdd.Next = next;
        toAdd.Prev = current;
        
        if (next is not null)
            next.Prev = toAdd;

        current.Next = toAdd;
        Count++;
    }
    
    public override string ToString()
    {
        var builder = new StringBuilder($"{Head.Value}");
        var current = Head;
        
        while (current.Next is not null)
        {
            builder.Append($"-->{current.Next.Value}");
            current = current.Next;
        }
        
        return builder.ToString();
    }
    
    public string RevToString()
    {
        var builder = new StringBuilder($"{Tail.Value}");
        var current = Tail;
        
        while (current.Prev is not null)
        {
            builder.Append($"-->{current.Prev.Value}");
            current = current.Prev;
        }
        
        return builder.ToString();
    }
}