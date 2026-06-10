// See https://aka.ms/new-console-template for more information

Console.WriteLine($"GCD of 60 and 36 is {GreatestCommonDivisor(60, 36)}");
Console.WriteLine($"GCD of 20 and 28 is {GreatestCommonDivisor(20, 28)}");

return;

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