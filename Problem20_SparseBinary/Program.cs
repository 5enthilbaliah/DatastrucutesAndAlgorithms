// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Console.WriteLine($"36 is sparse : {IsSparseBinary(36)}");
Console.WriteLine($"3 is sparse : {IsSparseBinary(3)}");
Console.WriteLine($"22 is sparse : {IsSparseBinary(22)}");

return;

bool IsSparseBinary(long number)
{
    var binary = Convert.ToString(number, 2);

    var regex = new Regex("^(0|10)*1?$");
    var match = regex.Match(binary);
    return match.Success;
}
