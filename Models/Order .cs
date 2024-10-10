
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Productos_Pedidos.Models
{
    [Table("orders")]
    public class Order 
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}

        [Column("order_date")]
        public DateTime OrderDate { get; set;}

        [Column("customer")]
        public User userInfo { get; set;}

        public ICollection<OrderProduct> OrderProducts { get; set;}

    }
}