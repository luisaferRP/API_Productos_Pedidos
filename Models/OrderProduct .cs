
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_Productos_Pedidos.Models
{
    [Table("order_products")]
    public class OrderProduct 
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}

        [Column("order_id")]
        public int OrderId { get; set;}

        [ForeignKey(nameof(OrderId))]
        public Order order{ get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}