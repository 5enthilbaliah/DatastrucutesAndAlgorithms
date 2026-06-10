// See https://aka.ms/new-console-template for more information

const int a1 = 1;
const int a2 = 3;
const int n = 10;

Console.WriteLine($"Using loop Nth number in AP for a1 = {a1}, a2 = {a2}, n = {n} is {NthNumberInApWithLoop(a1, a2, n)}");
Console.WriteLine($"Without loop Nth number in AP for a1 = {a1}, a2 = {a2}, n = {n} is {NthNumberInApWithoutLoop(a1, a2, n)}");

return;

int NthNumberInApWithLoop(int a1, int a2, int n)
{
    if (n == 1)
        return a1;
    
    if (n == 2)
        return a2;
    
    var difference = a2 - a1;

    var result = a2;
    for (var i = 3; i <= n; i++)
    {
        result += difference;
    }
    
    return result;
}

int NthNumberInApWithoutLoop(int a1, int a2, int n)
{
    if (n == 1)
        return a1;
    
    if (n == 2)
        return a2;
    
    var difference = a2 - a1;

    return a2 + difference * (n -2);
}