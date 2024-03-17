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
        for (var i = 0; i < array.Length; i++)
        {
            if (_hash.Contains(array[i]))
                return true;

            _hash.Add(array[i]);
        }

        return false;
    }
}