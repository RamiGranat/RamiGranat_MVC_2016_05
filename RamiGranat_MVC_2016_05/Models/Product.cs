using System.ComponentModel.DataAnnotations;

namespace RamiGranat_MVC_2016_05.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string ProductText { get; set; }
        [ProductNumber]
        [Required]
        public string ProductNumber { get; set; }
        [Required]
        public double Price { get; set; }
        public int ProductsInStock { get; set; }
    }
}