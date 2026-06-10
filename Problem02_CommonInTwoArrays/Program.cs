// See https://aka.ms/new-console-template for more information

// O(n^2)

using System.Text.Json;
using CommonInTwoArrays;

bool HasCommonData(char[] arr1, char[] arr2)
{
    foreach (var a1 in arr1)
    {
        foreach (var a2 in arr2)
        {
            if (a1 == a2)
                return true;
        }
    }

    return false;
}

// O(n)
bool HasCommonDataOptimized(char [] arr1, char [] arr2)
{
    var map = new HashSet<char>();

    char [] shorter;
    char[] current;

    if (arr1.Length < arr2.Length)
    {
        shorter = arr1;
        current = arr2;
    }
    else
    {
        shorter = arr2;
        current = arr1;
    }
    
    for (var i = 0; i < shorter.Length; i++)
    {
        if (!map.Contains(shorter[i]))
            map.Add(shorter[i]);

        if (map.Contains(current[i]))
            return true;
    }

    for (var i = shorter.Length; i < current.Length; i++)
    {
        if (map.Contains(current[i]))
            return true;
    }

    return false;
}

int MaxSubArraySum(int[] numbers)
{
    if (!numbers.Any(x => x < 0)) return numbers.Sum(x => x);
    
    var maxSum = numbers[0];
    var length = numbers.Length;
    for (var i = 0; i < length; i++)
    {
        for (var j = 1; j <= length - i; j++)
        {
            var sum = numbers.Skip(i).Take(j).Sum(x => x);
            // Console.WriteLine("{0}, {1}, {2}, {3}", i, j, length - i, sum);
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
    }
        
    return maxSum;
}

int? MissingInteger(int[] numbers, int length)
{
    if (length - numbers.Length != 1) 
        throw new Exception("The length array should be exactly one less that length");

    var hash = new HashSet<int>();
    foreach (var number in numbers)
    {
        hash.Add(number);
    }
    
    return Enumerable.Range(1, length).FirstOrDefault(x => !hash.Contains(x));
}

IEnumerable<int> LeadersInArray(int[] numbers)
{
    for (var i = 0; i < numbers.Length; i++)
    {
        var cadet = numbers[i];
        if (numbers.Skip(i + 1).All(x => x < cadet))
            yield return cadet;
    }
}

IEnumerable<int> RotateArray(int[] numbers, int k)
{
    var length = numbers.Length;
    var actualRotation = k < numbers.Length ? k : numbers.Length - k;

    if (actualRotation == 0)
    {
        foreach (var number in numbers)
        {
            yield return number;
        }
    }
    else
    {
        foreach (var number in numbers.Skip(length - actualRotation))
        {
            yield return number;
        }
        
        foreach (var number in numbers.Take(length - actualRotation))
        {
            yield return number;
        }
    }
}

IEnumerable<int> BitonicSubArray2(int[] numbers)
{
    var length = numbers.Length;
    var aggregates = numbers.Take(length - 1).Select((current, i) => new
    {
        Current = current,
        Index = i,
        NextIsGreater = current < numbers[i + 1],
    });

    var pitStopIndexes = aggregates.Where(x => !x.NextIsGreater)
        .Select(x => x.Index);

    return pitStopIndexes;
}

IEnumerable<int> BitonicSubArray(int[] numbers)
{
    var length = numbers.Length;
    var bitonicSubArray = new[] { numbers[0] };
    var maxLength = 1;
    for (int i = 0; i < length; i++)
    {
        var sub = new List<int> { numbers[i] };
        var k = i + 1;
        for (int j = i; j < length - 1; j++)
        {
            if (numbers[j] < numbers[j + 1])
            {
                sub.Add(numbers[j + 1]);
                k = j + 1;
            }
            else
            {
                break;
            }
        }

        for (int j = k + 1; j < length - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                sub.Add(numbers[j]);

                if (j + 1 == length - 1)
                {
                    sub.Add(numbers[j + 1]);
                }
            }
            else
            {
                break;
            }
        }

        if (maxLength < sub.Count)
        {
            maxLength = sub.Count;
            bitonicSubArray = sub.ToArray();
        }
    }
    
    return bitonicSubArray;
}



int PlatformsRequired(int[] arr, int[] dep)
{
    var platforms = new List<Queue<int>>();

    for (int i = 0; i < arr.Length; i++)
    {
        var availablePlatform = platforms.FirstOrDefault(x => x.Peek() < arr[i]);

        if (availablePlatform == null)
        {
            var queue = new Queue<int>();
            queue.Enqueue(dep[i]);
            platforms.Add(queue);
        }
        else
        {
            availablePlatform.Dequeue();
            availablePlatform.Enqueue(dep[i]);
        }
    }
    
    return platforms.Count;
}

int EquilibriumIndex(int[] numbers)
{
    var length = numbers.Length;
    return Enumerable.Range(1, length - 1).Select(idx => new
    {
        LeftSum = numbers.Take(idx).Sum(),
        RightSum = numbers.Skip(idx + 1).Sum(),
        Index = idx,
    }).FirstOrDefault(x => x.LeftSum == x.RightSum)?.Index ?? -1;
}

bool IsPalindrome(string s)
{
    for(int i = 0; i < s.Length / 2; i++)
        if (s[i] != s[s.Length - 1 - i])
            return false;

    return true;
}

string LargestPalindrome(string input)
{
    var result = Enumerable.Range(0, input.Length)
        .SelectMany(outerIdx => Enumerable.Range(outerIdx, input.Length - outerIdx)
                .Select(innerIdx => input.Substring(outerIdx, input.Length - innerIdx))
        ).Where(IsPalindrome).OrderByDescending(x => x.Length).ToList();

    return result.FirstOrDefault() ?? string.Empty;
}

// Console.WriteLine("{0}", MaxSubArraySum(new[] { 2, 3, -8, 7, -1, 2, 3 }));
// var missingInteger = MissingInteger(new[] { 1, 2, 3, 5 }, 5);
// var res = missingInteger.HasValue ? $"{missingInteger.Value}" : "NA";
// Console.WriteLine($"The missing integer is {res}");

// Console.WriteLine("{0}", JsonSerializer.Serialize(LeadersInArray(new [] { 1, 2, 3, 4, 5, 2 })));

// Console.WriteLine("{0}", JsonSerializer.Serialize(RotateArray(new [] { 1, 2, 3, 4, 5 }, 4)));

// Console.WriteLine("{0}", JsonSerializer.Serialize(BitonicSubArray2(new [] { 12, 4, 78, 90, 45, 23 })));
// Console.WriteLine("{0}", JsonSerializer.Serialize(BitonicSubArray(new [] { 10, 20, 30, 40 })));

// var arrival = new[] { 900, 940, 950, 1100, 1500, 1800 };
// var departure = new[] { 910, 1200, 1120, 1130, 1900, 2000 };
// Console.WriteLine("{0}", PlatformsRequired(arrival, departure ));

// Console.WriteLine("{0}", EquilibriumIndex(new [] { 1, 2, 0, 3 }));

Console.WriteLine(LargestPalindrome("forgeeksskeegfor"));

// Console.WriteLine("Brute-Force O(n^2) :");
// Console.WriteLine(HasCommonData(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'x'}));
// Console.WriteLine(HasCommonData(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'i'}));
//
// Console.WriteLine("Optimized O(n) :");
// Console.WriteLine(HasCommonDataOptimized(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'x'}));
// Console.WriteLine(HasCommonDataOptimized(new []{ 'a', 'b', 'c', 'x'}, new []{ 'z', 'y', 'i'}));