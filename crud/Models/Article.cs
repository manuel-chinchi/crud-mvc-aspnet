using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class Article
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [RegularExpression(@"^\w+( +\w+)*$", ErrorMessage = "'Nombre' no puede ser solamente espacios en blanco, ni contener espacios al inicio o al final.")]
        [Required(ErrorMessage = "'Nombre' no puede ser vacío.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Descripción")]
        public string Description { get; set; }
        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "'Cantidad' es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "'Cantidad' debe ser mayor o igual a 1.")]
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public Article() { DateCreated = DateTime.UtcNow; DateUpdated = null; }
    }
}