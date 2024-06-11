using System.Collections;

namespace EnumeratorPlayground
{
    internal class Program
    {
        static IEnumerable GetMoreNumbers()
        {
            yield return 4;
            yield return 5;
            yield return 6;
        }

        static IEnumerable GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            //var e = GetMoreNumbers().GetEnumerator();
            //e.MoveNext();
            yield return GetMoreNumbers();
        }

        static void Main(string[] args)
        {
            foreach (int n in GetNumbers())
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}