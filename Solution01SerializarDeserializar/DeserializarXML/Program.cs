using System;
using System.IO;
using System.Xml.Serialization;


namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"D:\Bucket\arquivo.xml");

            XmlSerializer serial = new XmlSerializer(typeof(Usuario.Usuario));
            Usuario.Usuario usuario = (Usuario.Usuario)serial.Deserialize(stream);

            Console.WriteLine("Usuario: {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}
