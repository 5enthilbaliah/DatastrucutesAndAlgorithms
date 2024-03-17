namespace Ds02_HashTables;

public class FirstRecurringNumber
{
    private HashSet<int> _hash = new HashSet<int>();

    public int? Execute(int[] array)
    {
        var result = default(int?);

        foreach (var i in array)
        {
            if (_hash.Contains(i))
            {
                result = i;
                break;
            }

            _hash.Add(i);
        }

        return result;
    }
}