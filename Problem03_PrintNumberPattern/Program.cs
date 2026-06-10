// See https://aka.ms/new-console-template for more information

foreach (var item in PrintPattern(3))
{
    if (item > 0)
        Console.Write(item);
    else
        Console.WriteLine("");
}

return;

IEnumerable<int> PrintPattern(int n)
{
    if (n <= 0)
        yield return n;

    for (var i = n; i > 0; i--) // No of repetitions
    {
        for (var j = n; j > 0; j--) // No to repeat
        {
            for (var k = 0; k < i; k++) // Repeat
            {
                yield return j;
            }
        }

        yield return -1;
    }
}
