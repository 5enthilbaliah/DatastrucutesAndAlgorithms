// See https://aka.ms/new-console-template for more information

var result = HasPairMatchingSum (new int [] { 1, 2, 3, 4, 5, 6 }, 8 );
Console.WriteLine(result);
return;


bool HasPairMatchingSum(IEnumerable<int> arr, int sum)
{
    var compliments = new HashSet<int>();
    foreach (var num in arr)
    {
        if (compliments.Contains(num))
            return true;

        compliments.Add(sum - num);
    }
    
    return false;
}