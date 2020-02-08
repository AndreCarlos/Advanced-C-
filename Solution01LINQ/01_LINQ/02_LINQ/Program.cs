using System;
using System.Linq;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //var filtrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);
            var filtrada = from a in lista where a > 10 orderby a select a;

            foreach (var item in filtrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
