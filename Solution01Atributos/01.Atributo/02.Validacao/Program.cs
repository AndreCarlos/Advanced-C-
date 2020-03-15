using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _02.Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Jose", Email = "jose", Senha = "1234" };

            ValidationContext contexto = new ValidationContext(usuario);

            List<ValidationResult> resultados = new List<ValidationResult>();


            if(Validator.TryValidateObject(usuario, contexto, resultados, true) == false)
            {
                // mensagens
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }
}