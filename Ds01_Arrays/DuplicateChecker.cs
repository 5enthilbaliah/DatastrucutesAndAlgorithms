namespace Ds01_Arrays;

public class DuplicateChecker
{
    private HashSet<int> _hash;

    public DuplicateChecker()
    {
        _hash = new HashSet<int>();
    }

    public bool Execute(int[] array)
    {
        foreach (var t in array)
        {
            if (_hash.Contains(t))
                return true;

            _hash.Add(t);
        }

        return false;
    }
}