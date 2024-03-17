// See https://aka.ms/new-console-template for more information

using Ds02_HashTables;

// Do not push duplicates - This is only understand the algorithms
var hashTable = new HashiTable(50);

hashTable.Set("grapes", 1000);
hashTable.Set("apples", 750);
hashTable.Set("oranges", 500);
hashTable.Set("peaches", 2500);

var exists = hashTable.TryGet("grapes", out var result);
var exists2 = hashTable.TryGet("oranges", out var result2);

if (exists)
    Console.WriteLine(result);
else 
    Console.WriteLine("Not found");
    
if (exists2)
    Console.WriteLine(result2);
else 
    Console.WriteLine("Not found");

foreach (var key in hashTable.Keys)
{
    Console.WriteLine(key);
}

var firstRecurring = new FirstRecurringNumber().Execute(new [] { 2, 5, 1, 2, 3, 5, 1, 2, 4 });
Console.WriteLine(firstRecurring.HasValue ? $"{firstRecurring}" : "Not Found");