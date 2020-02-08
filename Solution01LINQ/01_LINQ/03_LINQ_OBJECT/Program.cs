using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LINQ_OBJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();

            lista.Add(new Usuario { Nome = "jose", Email = "jose@gmail.com" });
            lista.Add(new Usuario { Nome = "maria", Email = "maria@hotmail.com" });
            lista.Add(new Usuario { Nome = "joao", Email = "joao@ig.com" });
            lista.Add(new Usuario { Nome = "felipe", Email = "felipe@gmail.com" });
            lista.Add(new Usuario { Nome = "elias", Email = "elias@gmail.com" });

            var filtrada = lista.Where(u => u.Email.Contains("@gmail.com")).OrderBy(u => u.Nome).Select(u => u);

            foreach (var item in filtrada)
            {
                Console.WriteLine(item.Nome + " - " + item.Email);
            }

            Console.ReadKey();
        }
    }
}