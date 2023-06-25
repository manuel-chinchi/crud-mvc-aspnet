using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [RegularExpression(@"^\w+( +\w+)*$", ErrorMessage = "'Nombre' no puede ser solamente espacios en blanco, ni contener espacios al inicio o al final.")]
        [Required(ErrorMessage = "'Nombre' no puede ser vacío.")]
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        // Navigation properties
        public virtual ICollection<Article> Articles { get; set; }

        public Category() { DateCreated = DateTime.Now; }
    }
}