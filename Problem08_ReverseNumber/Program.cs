// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Reverse of 122 is {ReverseNumber(122)}");
Console.WriteLine($"Reverse of 200 is {ReverseNumber(200)}");
return;

int ReverseNumber(int n)
{
    var reverse = 0;
    var remaining = n;
    do
    {
        var remainder = remaining % 10;
        reverse = reverse * 10 + remainder;

        remaining /= 10;
    } while (remaining > 0);
    
    return reverse;
}