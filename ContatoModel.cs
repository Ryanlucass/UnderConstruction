using System;
using System.ComponentModel.DataAnnotations;

namespace UnderConstruction
{
    public class ContatoModel
    {
        public int Codigo { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }   

    public static class ContatoModelErrorMenssages
    {
        public static string NomeNaoVazio = "O campo nome não pode ser vazio";
        public static string NomeExcedeuTamano = "O nome exedeu a quantidade de caracteres aceitáveis";
        public static string NomeCurto = "O campo nome está muito curto para se considerar um campo válido";


        public static string CodigoVazio = "O codigo não pode ser vazio";
        public static string CodigoExcedido = "O código execdeu a quantidade esperada";
        public static string CodigoCurto = "O código é muito curto para ser considerado";
    }


    public class ContatoModelValidator : AbstractValidator<ContatoModel>
    {
        public ContatoModelValidator()
        {
            //RuleFor(c => c.Nome).Empty().WithMessage(ContatoModelErrorMenssages.NomeNaoVazio)
            //                    .MaximumLength(50).WithMessage(ContatoModelErrorMenssages.NomeExcedeuTamano)
            //                    .MinimumLength(10).WithMessage(ContatoModelErrorMenssages.NomeCurto);

            //RuleFor(c => c.Codigo).Empty().WithMessage(ContatoModelErrorMenssages.CodigoVazio)
            //                      .Null().WithMessage(ContatoModelErrorMenssages.CodigoVazio);
        }
    }
}

