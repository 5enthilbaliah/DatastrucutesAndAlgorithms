// See https://aka.ms/new-console-template for more information
var x = 2;
var y = 8;
Console.WriteLine($"Is {y} a power of {x} = {CheckForPower(x, y)}");

x = 1;
y = 8;
Console.WriteLine($"Is {y} a power of {x} = {CheckForPower(x, y)}");

x = 46;
y = 205962976;
Console.WriteLine($"Is {y} a power of {x} = {CheckForPower(x, y)}");
return;


bool CheckForPower(int x, int y)
{
    if (x <= 1)
        return false;
    
    var pow = 1;
    var product = x;

    while (product < y)
    {
        product *= x;
        pow++;
    }

    return product == y;
}