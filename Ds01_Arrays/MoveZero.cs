namespace Ds01_Arrays;

public class MoveZero
{
    private int[] _result;

    public int[] Execute(int[] array)
    {
        _result = new int [array.Length];
        for (int i = 0, j = array.Length - 1, k = 0; k <= j; i++)
        {
            if (array[i] == 0)
            {
                _result[j] = array[i];
                j--;
                continue;
            }
            
            _result[k] = array[i];
            k++;
        }

        return _result;
    }
}