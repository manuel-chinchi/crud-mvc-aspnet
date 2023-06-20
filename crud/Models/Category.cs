﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public Category() { DateCreated = DateTime.Now; }
    }
}