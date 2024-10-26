// See https://aka.ms/new-console-template for more information

using Ds04_StacksNQueues;

var stack = new Stacki<int>(10);

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);

while (stack.Peek().HasValue)
{
    var value = stack.Pop();
    Console.Write($"{value}-->");
}

var queue = new Queuei<int>(10);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);

while (queue.Peek().HasValue)
{
    var value = queue.Dequeue();
    Console.Write($"{value}-->");
}
