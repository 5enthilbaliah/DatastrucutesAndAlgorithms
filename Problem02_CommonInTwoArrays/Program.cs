// See https://aka.ms/new-console-template for more information

// O(n^2)
bool HasCommonData(char[] arr1, char[] arr2)
{
    foreach (var a1 in arr1)
    {
        foreach (var a2 in arr2)
        {
            if (a1 == a2)
                return true;
        }
    }

    return false;
}

// O(n)
bool HasCommonDataOptimized(char [] arr1, char [] arr2)
{
    var map = new HashSet<char>();

    char [] shorter;
    char[] current;

    if (arr1.Length < arr2.Length)
    {
        shorter = arr1;
        current = arr2;
    }
    else
    {
        shorter = arr2;
        current = arr1;
    }
    
    for (var i = 0; i < shorter.Length; i++)
    {
        if (!map.Contains(shorter[i]))
            map.Add(shorter[i]);

        if (map.Contains(current[i]))
            return true;
    }

    for (var i = shorter.Length; i < current.Length; i++)
    {
        if (map.Contains(current[i]))
            return true;
    }

    return false;
}

Console.WriteLine("Brute-Force O(n^2) :");
Console.WriteLine(HasCommonData(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'x'}));
Console.WriteLine(HasCommonData(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'i'}));

Console.WriteLine("Optimized O(n) :");
Console.WriteLine(HasCommonDataOptimized(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'x'}));
Console.WriteLine(HasCommonDataOptimized(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'i'}));