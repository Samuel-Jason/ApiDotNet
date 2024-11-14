using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Title { get; set; }
        [MaxLength(400)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage ="O Preço deve ser maior que zero")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
