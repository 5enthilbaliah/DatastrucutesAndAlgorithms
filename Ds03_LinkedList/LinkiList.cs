﻿// ReSharper disable All
namespace Ds03_LinkedList;

using System.Text;

public class LinkiListNode<T>
{
    public T Value { get; set; }
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

    private LinkiListNode<T> TraverseTo(int position)
    {
        var current = Head!;
        for (var runner = 1; runner < position; runner++)
        {
            current = current.Next!;
        }

        return current;
    }

    public T LookUp(int position)
    {
        var current = TraverseTo(position);
        return current.Value;
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

            if (Count == 1)
            {
                Tail = Head;
            }
            
            return value;
        }

        var current = TraverseTo(position);
        var toRemove = current.Next!;
        current.Next = toRemove.Next;
        Count--;
        
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
        var toAdd = new LinkiListNode<T>(value);
        toAdd.Next = current.Next;
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
}