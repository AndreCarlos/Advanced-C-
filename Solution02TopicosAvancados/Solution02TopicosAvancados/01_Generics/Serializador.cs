using System.IO;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            StreamWriter writer = new StreamWriter(@"D:\Bucket\" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serial = new JavaScriptSerializer();
            string serializado = serial.Serialize(obj);

            writer.Write(serializado);
            writer.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader reader = new StreamReader(@"D:\Bucket\" + typeof(T).Name + ".txt");
            string arquivo = reader.ReadToEnd();

            JavaScriptSerializer serial = new JavaScriptSerializer();
            T obj = (T)serial.Deserialize(arquivo, typeof(T));

            return obj;
        }
    }
}