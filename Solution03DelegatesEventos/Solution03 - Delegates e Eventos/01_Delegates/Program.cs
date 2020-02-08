using System;

namespace _01_Delegates
{
    class Program
    {
        delegate int calcular(int a, int b);

        static void Main(string[] args)
        {
            calcular cal1 = new calcular(soma);
            int so = cal1(10, 20);

            calcular cal2 = new calcular(subtrair);
            int su = cal2(30, 15);


            //var so = soma(10, 20);
            //var su = subtrair(20, 10);

            Console.WriteLine("soma : " + so);
            Console.WriteLine("subracao : " + su);


            Console.ReadKey();
        }

        static int soma(int a, int b)
        {
            return a + b;
        }

        static int subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
