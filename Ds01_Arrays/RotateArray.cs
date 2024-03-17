namespace Ds01_Arrays;

public class RotateArray
{
    private int[] _array;

    public RotateArray(int[] array)
    {
        _array = array;
    }

    public int[] Execute(int number)
    {
        var rotationsNeeded = _array.Length > number ? number :  number % _array.Length;
        var rotated = new int [_array.Length];

        var j = 0;
        for (var i = _array.Length - rotationsNeeded; i < _array.Length; i++)
        {
            rotated[j] = _array[i];
            j++;
        }

        if (j >= _array.Length) return rotated;
        
        for (var i = 0; i < _array.Length - rotationsNeeded; i++)
        {
            rotated[j] = _array[i];
            j++;
        }

        return rotated;
    }
}