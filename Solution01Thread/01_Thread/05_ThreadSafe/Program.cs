using System;
using System.Threading;

namespace _05_ThreadSafe
{
    class Program
    {
        static int Rede = 0;
        static object variavelDeControle = 0;

        //IO - Input|Output - Lento (tela, rede, armazenamento, impressora na rede)
        static void Main(string[] args)
        {
            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeat);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }

        //IO - Tela, Rede, Armazenamento.
        static void ThreadRepeat()
        {
            //lock => FIFO - Fist In, First Out
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine("Num: " + i);
                    Rede++;
                }
            }
            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}