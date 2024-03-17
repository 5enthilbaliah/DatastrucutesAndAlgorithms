// See https://aka.ms/new-console-template for more information

using Ds01_Arrays;

string Reverse(string str)
{
    if (string.IsNullOrEmpty(str))
        return str;
    
    var reverse = new char[str.Length];
    for (int i = 0, j = str.Length - 1; j >= 0; j--, i++)
    {
        reverse[i] = str[j];
    }

    return new string(reverse);
}

// In C# array is only an IEnumerable so it cannot be used for insert or delete; You can use the ArrayList instead
// List is comparable to dynamic array implementation

// ReSharper disable once UseObjectOrCollectionInitializer
var strings = new List<char>
{
    'b', 
    'c', 
    'd', 
    'e'
};

// push
strings.Add('f');

// pop
strings.RemoveAt(strings.Count - 1);

// Unshift O(n)
strings.Insert(0, 'a');

// Splice
strings.Insert(3, 'g');

Console.WriteLine($"{strings[0]}, {strings[3]}");

Console.WriteLine(Reverse("Check 12345"));

Console.WriteLine( string.Join(',', new MergeSortedArray(new [] { 0, 3, 4, 31})
    .CombineAndSortWith(new [] { 4, 6, 30}).Select(x => $"{x}")));
    
var (subSet, sum) = new MaxSubArraySum(new [] { -2, -3, 4, -1, -2, 1, 5, -3 })
        .Execute();
        
Console.WriteLine( string.Join(',', subSet.Select(x => $"{x}")));

var rotated = new RotateArray(new [] { 1, 2, 3, 4, 5, 6, 7 }).Execute(14);
Console.WriteLine( string.Join(',', rotated.Select(x => $"{x}")));
