namespace linq;

class Program
{



    static void Main(string[] args)
    {
        Console.WriteLine(0);
        IEnumerable<int> enumerator = Select<int, int>(null, x => x * 2);
        Console.WriteLine(1);
        IEnumerator<int> iterator = enumerator.GetEnumerator();
        Console.WriteLine(2);
        iterator.MoveNext();
    }

    static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(selector);

        return Impl(source, selector);

        static IEnumerable<TResult> Impl<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {

            foreach (var item in source)
            {
                yield return selector(item);
            }
        }
    }
}






