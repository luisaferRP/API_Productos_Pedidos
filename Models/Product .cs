
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_Productos_Pedidos.Models
{
    [Table("products")]
    public class Product 
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}

        [Column("name")]
        public string Name { get; set;}

        [Column("description")]
        public string? Description { get; set;}

        [Column("price")]
        public double Price { get; set;}

        [Column("stock")]
        public int Stock {get; set;}

        [Column("category_id")]
        public int CategoryId { get; set;}

        [ForeignKey(nameof(CategoryId))]
        public Category category { get; set;}

        public ICollection<OrderProduct> OrderProducts { get; set;}
    }
}