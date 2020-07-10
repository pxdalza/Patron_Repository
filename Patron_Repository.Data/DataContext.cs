using Microsoft.EntityFrameworkCore;
using Patron_Repository.Data.Models;
using System;

namespace Patron_Repository.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=localhost;Database=Almacen;Uid=root;Pwd=root;");               
                optionsBuilder.UseSqlServer("Server=localhost;Database=Almacen;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasKey(x => x.ProductId);
            modelBuilder.Entity<Products>().HasIndex(x => x.Code).IsUnique();
        }
    }
}
