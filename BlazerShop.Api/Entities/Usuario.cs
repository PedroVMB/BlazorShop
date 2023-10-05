using System.ComponentModel.DataAnnotations;

namespace BlazerShop.Api.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string NomeUsuario { get; set; } = string.Empty;

        public Carrinho? Carrinho { get; set; }


    }
}
