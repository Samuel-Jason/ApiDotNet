using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Esse campo é Obrigatório!")]
        [DataType("nvarchar")]
        public string Title { get; set; }
    }
}
