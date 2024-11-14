using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Esse Campo é Obrigatório")]
        [MaxLength(20, ErrorMessage = "Esse campo deve ter no Maximo entre 3 e 60 Caracteres")]
        [MinLength(1, ErrorMessage = "Esse campo deve ter no minimo 3 Caracteres")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Esse Campo é Obrigatório")]
        [MaxLength(20, ErrorMessage = "Esse campo deve ter no Maximo entre 3 e 60 Caracteres")]
        [MinLength(1, ErrorMessage = "Esse campo deve ter no minimo 3 Caracteres")]
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
