using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Productos_Pedidos.Models
{
    [Table("categories")]
    public class Category 
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}

        [Column("name")]
        public string Name { get; set;}

        [Column("description")]
        public string Description { get; set;}

        //cargar solo los productos que pertenecen a esa categoría específica
        public ICollection<Product> Products { get; set;}
    }
}