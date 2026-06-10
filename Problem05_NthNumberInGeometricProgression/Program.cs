// See https://aka.ms/new-console-template for more information

const int a = 4;
const int r = 3;
const int n = 4;

Console.WriteLine($"Using loop Nth number in AP for a = {a}, r = {r}, n = {n} is {NthNumberInGpWithLoop(a, r, n)}");
Console.WriteLine($"Using loop Nth number in AP for a = {a}, r = {r}, n = {n} is {NthNumberInGpWithoutLoop(a, r, n)}");

return;

int NthNumberInGpWithLoop(int a, int r, int n)
{
    if (n == 1)
        return a;
    

    var result = a;
    for (var i = 2; i <= n; i++)
    {
        result *= r;
    }
    
    return result;
}

double NthNumberInGpWithoutLoop(int a, int r, int n)
{
    if (n == 1)
        return a;

    return a * Math.Pow(r, n - 1);
}