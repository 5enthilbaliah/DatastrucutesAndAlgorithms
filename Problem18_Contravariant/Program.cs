// See https://aka.ms/new-console-template for more information

var apples = new List<Apple>()
{
    new Apple { Name = "Granny Smith", Weight = 80 },
    new Apple { Name = "Arthur Turner", Weight = 70 },
    new Apple { Name = "Honeygold", Weight = 80 },
    new Apple { Name = "Kerry Pippin",  Weight = 82 },
    new Apple { Name = "Newton Womder",  Weight = 75 },
};

foreach (var apple in apples)
    Console.WriteLine(apple);

Console.WriteLine();


Sort(apples, new FruitWeightComparer());

foreach (var apple in apples)
    Console.WriteLine(apple);

return ;

void Sort(List<Apple> collection, IWeightComparer<Apple> comparer)
{
    collection.Sort(new ComparerAdapter<Apple>(comparer));
}

public interface IWeightComparer<in T>
{
    int Compare(T x, T y);
}

public class AppleWeightComparer : IWeightComparer<Apple>
{
    public int Compare(Apple x, Apple y) => (int)(x.Weight - y.Weight);
}

public class FruitWeightComparer : IWeightComparer<Fruit>
{
    public int Compare(Fruit x, Fruit y) => (int)(x.Weight - y.Weight);
}

public class Fruit
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Weight}";
    }
}

public class Apple : Fruit
{
    
}

public class ComparerAdapter<T>(IWeightComparer<T> innerCompare) : IComparer<T>
{
    public int Compare(T? x, T? y)
    {
        return innerCompare.Compare(x!, y!);
    }
}