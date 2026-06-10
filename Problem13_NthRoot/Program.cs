// See https://aka.ms/new-console-template for more information

Console.WriteLine($"3rd root of 8 is {FindNthRoot(3, 8)}");
Console.WriteLine($"3rd root of 9 is {FindNthRoot(3, 9)}");
Console.WriteLine($"4th root of 16 is {FindNthRoot(4, 16)}");
return;

int FindNthRoot(int n, int m)
{
    if (m == 1)
        return 1;
    
    for (var i = 2; i <= m / 2; i++)
    {
        var product = 1;

        for (int j = 0; j < n; j++)
        {
            product *= i;
            if (product > m)
                break;
        }
        
        if (product == m)
            return i;
    }

    return -1;
}