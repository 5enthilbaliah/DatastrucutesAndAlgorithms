// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Decimal value of binary 111 is {BinaryToDecimal(111)}");
Console.WriteLine($"Decimal value of binary 100001 is {BinaryToDecimal(100001)}");

return;

int BinaryToDecimal(int n)
{
    var pos = 0;
    var remaining = n;
    var dec = 0;
    
    do
    {
        var remainder = remaining % 10;
        if (remainder > 1)
        {
            throw new ArgumentOutOfRangeException("Binary value should have 0s and 1s");
        }

        if (remainder == 1)
        {
            dec += (int) Math.Pow(2, pos);
        }
        remaining /= 10;
        pos++;
    } while ( remaining > 0 );
    
    return dec;
}