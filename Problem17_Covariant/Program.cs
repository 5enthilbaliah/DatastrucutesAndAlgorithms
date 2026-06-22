// See https://aka.ms/new-console-template for more information

var appleBag = new Bag<Apple>();

appleBag.Add(new Apple { Name = "Granny Smith" });
appleBag.Add(new Apple { Name = "Cox's Orange Pippin" });
appleBag.Add(new Apple { Name = "Golden Delicious" });


IBag<Fruit> fruitBag = appleBag;
for(var i = 0; i < fruitBag.Count; i++)
    Console.WriteLine(fruitBag.Get(i).Name);

return;


public interface IBag<out T>
{
    T Get(int index);
    int Count { get; }
}

public class Bag<T> : IBag<T>
{
    private IList<T> _items = new List<T>();


    public T Get(int index) => _items[index];
    public int Count => _items.Count;

    public void Add(T item) => _items.Add(item);
}

public abstract class Fruit
{
    public string Name { get; set; }
}

public class Apple : Fruit
{
    
}