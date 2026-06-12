// See https://aka.ms/new-console-template for more information

foreach (var perm in GetPermutations([1, 3, 5, 6, 7]))
{
    foreach (var item in perm)
    {
        Console.Write($"{item} ");
    }
    
    Console.WriteLine();
}

return;

IEnumerable<T[]> GetPermutations<T>(T[] array, int start = 0)
{
    if (start >= array.Length - 1)
        yield return (array.Clone() as T[])!;
    else
    {
        for (var i = start; i < array.Length; i++)
        {
            (array[start], array[i]) = (array[i], array[start]);

            foreach (var perm in GetPermutations(array, start + 1))
            {
                yield return perm;
            }
            
            
            (array[start], array[i]) = (array[i], array[start]);
        }
    }
    
}

