namespace Ds02_HashTables;

public class HashiTable
{
    private class KeyVal
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }

    private List<KeyVal>[] _data;

    public HashiTable(int size)
    {
        _data = new List<KeyVal>[size];
    }
    
    private int HashAlg(string key)
    {
        var hash = 0;
        for (var i = 0; i < key.Length; i++)
        {
            hash = (hash + key[i] * i) % _data.Length;
        }

        return hash;
    }

    public void Set(string key, int value)
    {
        var address = HashAlg(key);
        
        // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
        _data[address] ??= new List<KeyVal>();
        _data[address].Add(new  KeyVal
        {
            Key = key,
            Value = value
        });
    }

    public bool TryGet(string key, out int? value)
    {
        var address = HashAlg(key);
        value = default;

        if (_data[address]?.Count() == 0)
            return false;

        var found = _data[address].FirstOrDefault(x => x.Key == key);
        value = found?.Value;

        return found != null;
    }
}