namespace Ds01_Arrays;

public class DuplicateChecker
{
    private readonly HashSet<int> _hash = [];

    public bool Execute(int[] array)
    {
        return array.Any(t => !_hash.Add(t));
    }
}