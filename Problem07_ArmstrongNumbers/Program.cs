// See https://aka.ms/new-console-template for more information


Console.WriteLine($"Is 153 an Armstrong number? {CheckIfArmstrongNumber(153)}");
Console.WriteLine($"Is 372 an Armstrong number? {CheckIfArmstrongNumber(372)}");


bool CheckIfArmstrongNumber(int n)
{
    var number = n;
    var armstrongCount = 0;
    do
    {
        var reminder = number % 10;
        armstrongCount += reminder * reminder * reminder;
        number /= 10;
    } 
    while (number > 0);

    return armstrongCount == n;
}