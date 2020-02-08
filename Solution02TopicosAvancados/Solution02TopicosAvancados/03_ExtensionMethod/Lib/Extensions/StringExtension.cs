
namespace System
{
    public static class StringExtension
    {
        public static string FirstToUpper(this string str)
        {
            string Primeira = str.Substring(0, 1);
           
            string Segunda = str.Substring(1);

            return Primeira.ToUpper() + Segunda;

        }

    }
}
