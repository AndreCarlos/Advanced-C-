using System;
using System.Threading;

namespace _06_ThreadID
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeat);
                t1.Start(i);
            }

            Console.WriteLine("Programa finalizado!");
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
