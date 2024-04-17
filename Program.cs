namespace linq;

class Program
{



    static void Main(string[] args)
    {
        IEnumerable<int> e = GetValues();
        IEnumerator<int> enumerator = e.GetEnumerator();
        Console.WriteLine(enumerator);
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
            int i = enumerator.Current;
            Console.WriteLine(i);
        }


        static IEnumerable<int> GetValues()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
