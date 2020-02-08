using _01_Generics;
using System;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        { 
            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Linea" };
            Casa casa = new Casa() { Cidade = "São Paulo", Enderco = "Siqueira Bueno, 1522" };
            Usuario usuario = new Usuario() { Nome = "Andre", Email = "andre@uol.com.br", Senha = "01234" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();


            Console.WriteLine("carro2: " + carro2.Marca + " - " + carro2.Modelo);
            Console.WriteLine("casa2: " + casa2.Cidade + " - " + casa2.Enderco);
            Console.WriteLine("usuario2 : " + usuario2.Nome + " - " + usuario2.Email + " - " + usuario2.Senha);

            Console.ReadKey();

        }
    }
}