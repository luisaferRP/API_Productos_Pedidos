using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Productos_Pedidos.Models
{
    [Table("users")]
    public class User 
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}

        [Column("name")]
        public string Name { get; set; }

        [Column("last_name")]
        public string LastName { get; set;}

        [Column("address")]
        public string Address { get; set; }

        [Column("contact")]
        public string Contact { get; set; }
        
    }
}