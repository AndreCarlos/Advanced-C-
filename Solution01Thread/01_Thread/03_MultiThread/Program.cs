using System.Threading;
using System;

namespace _03_MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeat);
                t1.Start();
            }

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();            
        }

        //IO - Tela, Rede, Armazenamento.
        static void ThreadRepeat()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num: " + i);
            }
        }
    }
}
