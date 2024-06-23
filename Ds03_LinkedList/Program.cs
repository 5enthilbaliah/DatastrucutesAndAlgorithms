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

linkList.InsertAt(1, 8);
linkList.InsertAt(5, 17);

Console.WriteLine(linkList.ToString());

var dLinkList = new DoublyLinkiList<int>(10);
dLinkList.AppendWith(11);
dLinkList.AppendWith(12);
dLinkList.AppendWith(13);
dLinkList.AppendWith(14);
dLinkList.AppendWith(15);

dLinkList.PrependWith(9);

dLinkList.RemoveAt(4);

dLinkList.RemoveAt(5);

dLinkList.InsertAt(1, 8);
dLinkList.InsertAt(5, 17);

Console.WriteLine(dLinkList.ToString());
Console.WriteLine(dLinkList.RevToString());
Console.ReadLine();