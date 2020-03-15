using System;

namespace _01.Atributo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    class MeuAtributo : Attribute
    {
        public MeuAtributo(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
