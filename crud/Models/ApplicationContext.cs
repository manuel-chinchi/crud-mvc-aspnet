using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Configure_Articles
            modelBuilder.Entity<Article>().ToTable("Articles");
            modelBuilder.Entity<Article>().HasKey(a => a.Id);
            modelBuilder.Entity<Article>().Property(a => a.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.Description).HasMaxLength(50);
            #endregion

            #region Configure_Categories
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(50).IsRequired();
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}