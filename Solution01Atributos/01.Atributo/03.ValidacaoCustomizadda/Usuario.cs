using System.ComponentModel.DataAnnotations;

namespace _03.ValidacaoCustomizadda
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório!")]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        [MinhaValidacao(ErrorMessage = "O campo senha deve possuir 10 caracteres!" )]
        public string Senha { get; set; }
    }
}
