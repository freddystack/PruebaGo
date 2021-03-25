using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaGo.Models
{
    public class MyModelContext : DbContext
    {
        public MyModelContext(DbContextOptions<MyModelContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }

    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public List<Categories> Categoeias { get; set; }

    }
    public class Categories
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
