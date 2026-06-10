// See https://aka.ms/new-console-template for more information

Console.WriteLine($"LCM of 24, 40 is {LeastCommonMultiple(24, 40)}");
Console.WriteLine($"LCM of 5, 10 is {LeastCommonMultiple(5, 10)}");
Console.WriteLine($"LCM of 24, 40 is {LeastCommonMultiple(14, 8)}");
Console.WriteLine($"LCM of 2, 10 is {LeastCommonMultiple(2, 10)}");
Console.WriteLine($"LCM of 1, 1 is {LeastCommonMultiple(1, 1)}");

Console.WriteLine($"LCM of 24, 40 using GCD is {LeastCommonMultipleUsingGCD(24, 40)}");
Console.WriteLine($"LCM of 5, 10 using GCD is {LeastCommonMultipleUsingGCD(5, 10)}");
Console.WriteLine($"LCM of 1, 1 using GCD is {LeastCommonMultipleUsingGCD(1, 1)}");

return;

int LeastCommonMultipleUsingGCD(int a, int b)
{
    return a * b / GreatestCommonDivisor(a, b);
}

int LeastCommonMultiple(int a, int b)
{
    if (a == 1 || b == 1)
    {
        return a * b;
    }
    
    var factors = new List<int>();
    var primeCount = 1;
    var primeValue = GetNthPrimeNumber(primeCount);

    do
    {
        var isDivisible = false;
        if (a % primeValue == 0)
        {
            isDivisible = true;
            a /= primeValue;
        }

        if (b % primeValue == 0)
        {
            isDivisible = true;
            b /= primeValue;
        }
        
        if (isDivisible)
            factors.Add(primeValue);
        else
        {
            primeCount++;
            primeValue = GetNthPrimeNumber(primeCount);
        }
        
    } while (primeValue <= a || primeValue <= b);
    
    return  factors.Aggregate((current, next) => current * next);
}

int GreatestCommonDivisor(int a, int b)
{
    var abs_a = Math.Abs(a);
    var abs_b = Math.Abs(b);
    var isFirstGreater = abs_a > abs_b;
    if (!isFirstGreater)
        (abs_a, abs_b) = (abs_b, abs_a);

    while (abs_b != 0)
    {
        (abs_a, abs_b) = (abs_b, abs_a % abs_b);
    }
    
    
    return abs_a;
}

int GetNthPrimeNumber(int n)
{
    if (n < 1) throw new ArgumentOutOfRangeException("n must be greater than zero");
    
    var count = 0;
    var candidate = 1;

    while (count < n)
    {
        candidate++;
        if (IsPrime(candidate))
        {
            count++;
        }
    }
    
    return candidate;
}

bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));
    for(var i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0) return false;
    }
    
    return true;
}