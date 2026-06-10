// See https://aka.ms/new-console-template for more information

Console.WriteLine($"6 is a perfect number? {PerfectNumber(6)}");
Console.WriteLine($"10 is a perfect number? {PerfectNumber(10)}");

return;


bool PerfectNumber(int n)
{
    var sum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
            sum += i;
    }
    
    return sum == n;
}