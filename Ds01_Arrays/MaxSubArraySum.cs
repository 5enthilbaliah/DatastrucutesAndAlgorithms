namespace Ds01_Arrays;

public class MaxSubArraySum
{
    private int[] _array;

    public MaxSubArraySum(int[] array)
    {
        _array = array;
    }

    public (int[] subSet, int sum ) Execute()
    {
        var size = _array.Length;
        var maxSoFar = int.MinValue;
        var maxFromLast = 0;
        var start = 0;
        var end = 0;
        var cursor = 0;

        for (var i = 0; i < size; i++)
        {
            maxFromLast += _array[i];
            if (maxSoFar < maxFromLast)
            {
                maxSoFar = maxFromLast;
                start = cursor;
                end = i;
            }

            if (maxFromLast < 0)
            {
                maxFromLast = 0;
                cursor = i + 1;
            }
        }

        return (_array[start .. (end+1)], maxSoFar);
    }
}