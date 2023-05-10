using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class Article
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Descripción")]
        public string Description { get; set; }
        [DisplayName("Cantidad")]
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public Article() { DateCreated = DateTime.UtcNow; DateUpdated = null; }
    }
}