namespace Ds01_Arrays;

public class MergeSortedArray
{
    private int[] _array1;

    private bool _reachedLength = false;
    
    public MergeSortedArray(int[] array1)
    {
        _array1 = array1;
    }

    public int[] CombineAndSortWith(int[] array2)
    {
        var merged = new int [_array1.Length + array2.Length];
        for (int i = 0, j = 0, k = 0; k < merged.Length; k++)
        {
            if (!_reachedLength)
                _reachedLength = j == array2.Length;
            
            if (_reachedLength || _array1[i] < array2[j])
            {
                merged[k] = _array1[i];
                i++;
                continue;
            } 
        
            merged[k] = array2[j];
            j++;
        }

        return merged;
    }
}