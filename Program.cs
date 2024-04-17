namespace linq;

class Program
{

    IEnumerable<Person> people = new List<Person>
    {
        new Person { Name = "John" },
        new Person { Name = "Jane" },
        new Person { Name = "Jack" }
    };

    IEnumerable<string> names = people.Select(p => p.Name);

    static void Main(string[] args)
    {
        static IEnumerable<TResult> Select<TSource, TResult>(IEnumeable<TSource> source)
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}

class Person
{
    public string Name { get; set; }

}
