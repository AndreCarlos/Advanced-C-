namespace _02_Delegates.Lib
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processar(Foto foto)
        {
            filtros(foto);

            //var filtros = new FotoFiltro();
            //filtros.Colorir(foto);
            //filtros.PretoBranco(foto);
            //filtros.GerarThumb(foto);
            //filtros.RedimensionarTamMedio(foto);
        }
    }
}
