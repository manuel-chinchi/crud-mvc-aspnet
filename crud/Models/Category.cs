using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        // Navigation properties
        public virtual ICollection<Article> Articles { get; set; }

        public Category() { DateCreated = DateTime.Now; }
    }
}