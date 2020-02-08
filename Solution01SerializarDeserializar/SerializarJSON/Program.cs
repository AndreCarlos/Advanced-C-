using System.IO;
using System.Web.Script.Serialization;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario.Usuario usuario = new Usuario.Usuario()
            {
                Nome = "Maria Costa da Silva",
                CPF = "333.333.33-00",
                Email = "maria.costa@yahoo.com"
            };

            JavaScriptSerializer serial = new JavaScriptSerializer();
            string objSerializado = serial.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"D:\Bucket\arquivo.json");
            sw.WriteLine(objSerializado);
            sw.Close();
        }
    }
}
