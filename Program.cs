namespace linq;

class Program
{



    static void Main(string[] args)
    {
        IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (int i in Select(numbers, i => i * 2))
        {
            Console.WriteLine(i);
        }
    }

    static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        foreach (var item in source)
        {
            yield return selector(item);
        }
    }
}






