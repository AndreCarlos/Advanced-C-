using System;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;
            t2 = "";

            var v1 = "";
            var v2 = 789456;

            //v2 = ""; => Erro
            //var v3; => Erro


            dynamic d1 = new Usuario { Nome = "Maria" };

            Console.WriteLine(d1.Nome);
            //Console.WriteLine(d1.Senha);  => Erro

            d1 = "";



            Console.ReadKey();
        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}