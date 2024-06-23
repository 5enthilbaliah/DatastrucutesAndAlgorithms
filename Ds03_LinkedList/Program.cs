// See https://aka.ms/new-console-template for more information

using Ds03_LinkedList;

var linkList = new LinkiList<int>(10);

linkList.AppendWith(11);
linkList.AppendWith(12);
linkList.AppendWith(13);
linkList.AppendWith(14);
linkList.AppendWith(15);

linkList.PrependWith(9);

linkList.RemoveAt(4);
linkList.RemoveAt(5);

var current = linkList.Head;

Console.WriteLine(current.Value);
while (current.Next is not null)
{
    Console.WriteLine(current.Next.Value);
    current = current.Next;
}

Console.ReadLine();