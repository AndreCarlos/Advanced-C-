using System.Xml.Serialization;
using System.IO;

namespace SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario.Usuario usuario = new Usuario.Usuario()
            {
                Nome = "Jose da Silva",
                CPF = "222.222.222-22",
                Email = "jose@yahoo.com"
            };

            XmlSerializer serial = new XmlSerializer(typeof(Usuario.Usuario));
            //XmlSerializer serial = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"D:\Bucket\arquivo.xml");

            serial.Serialize(stream, usuario);
        }
    }
}
