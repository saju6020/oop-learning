interface ISortingStrategy
{
    void Sort(List<int> list);
}

class QuickSort : ISortingStrategy
{
    public void Sort(List<int> list) => Console.WriteLine("QuickSort applied");
}

class BubbleSort : ISortingStrategy
{
    public void Sort(List<int> list) => Console.WriteLine("BubbleSort applied");
}

class SortingContext
{
    private ISortingStrategy _strategy;

    public void SetStrategy(ISortingStrategy strategy) => _strategy = strategy;

    public void SortList(List<int> list) => _strategy.Sort(list);
}

// Client
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 1, 2 };

        SortingContext context = new SortingContext();
        context.SetStrategy(new QuickSort());
        context.SortList(numbers);

        context.SetStrategy(new BubbleSort());
        context.SortList(numbers);
    }
}
