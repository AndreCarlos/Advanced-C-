using System;
using System.IO;
using System.Web.Script.Serialization;

namespace DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"D:\Bucket\arquivo.json");
            string fileLines = reader.ReadToEnd();

            JavaScriptSerializer serial = new JavaScriptSerializer();
            Usuario.Usuario usuario = (Usuario.Usuario) serial.Deserialize(fileLines, typeof(Usuario.Usuario));

            Console.WriteLine("Usuario: {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}
