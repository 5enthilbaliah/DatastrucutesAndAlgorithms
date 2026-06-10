// See https://aka.ms/new-console-template for more information

foreach ((var a, var b) in PairCubeCount(9))
{
    Console.WriteLine($"Pair for cube count 9 is {a}, {b}");
}

foreach ((var a, var b) in PairCubeCount(27))
{
    Console.WriteLine($"Pair for cube count 27 is {a}, {b}");
}

Console.WriteLine("Hello, World!");
return;

IEnumerable<(int a, int b)> PairCubeCount(int sum)
{
    var cubeDictionary = new Dictionary<int, int>();
    var cubeHashSet = new HashSet<int>();
    var i = 0;

    while (i * i * i <= sum)
    {
        cubeDictionary[i * i * i] = i;
        i++;
    }

    foreach (var kv in cubeDictionary)
    {
        var curr = kv.Key;
        var compliment = sum - curr;
        
        cubeHashSet.Add(curr);
        
        if (cubeDictionary.ContainsKey(compliment) && !cubeHashSet.Contains(compliment))
            yield return  (cubeDictionary[curr], cubeDictionary[compliment]);
    }
}