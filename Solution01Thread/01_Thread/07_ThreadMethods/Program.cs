using System;
using System.Threading;

namespace _07_ThreadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread Sleep
            Console.WriteLine("Início do nosso programa.");
            Thread.Sleep(3000);
            Console.WriteLine("Término do nosso programa.");


            //Thread Join
            Thread T1 = new Thread(ThreadRepeat);
            T1.Start();
            T1.Join();

            Console.WriteLine("Término do nosso programa.");
            Console.WriteLine("Término do nosso programa.");
            Console.WriteLine("Término do nosso programa.");
            Console.WriteLine("Término do nosso programa.");

            Console.ReadKey();
        }

        //IO - Tela, Rede, Armazenamento.
        static void ThreadRepeat(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: " + Id + " - Num: " + i + " - ID Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
