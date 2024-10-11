using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Productos_Pedidos.DTOS.request
{
    public class CategoryDTO 
    {
        [Required(ErrorMessage = "El nombre de la categoria es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "La descripción no puede exceder los 255 caracteres")]
        public string? Description { get; set; }

        
    }
}