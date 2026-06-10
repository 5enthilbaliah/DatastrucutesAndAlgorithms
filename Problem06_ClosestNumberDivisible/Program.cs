// See https://aka.ms/new-console-template for more information


Console.WriteLine($"Closest number to n -15 divisible by m 6 is {ClosestNumberDivisible(-15, 6)}");
Console.WriteLine($"Closest number to n 13 divisible by m 4 is {ClosestNumberDivisible(13, 4)}");

int ClosestNumberDivisible(int n, int m)
{
    if (m <= 0)
        throw new ArgumentOutOfRangeException("value should be greater than 0");

    var i = 1;
    while (true)
    {
        var prev = n - i;
        var next = n + i;
        

        var prevDivisible = prev % m == 0;
        var nextDivisible = next % m == 0;

        if (prevDivisible && !nextDivisible)
            return prev;

        if (nextDivisible && !prevDivisible)
            return next;

        if (nextDivisible && prevDivisible)
            return Math.Abs(prev) >  Math.Abs(next) ? prev : next;

        i++;
    }
}