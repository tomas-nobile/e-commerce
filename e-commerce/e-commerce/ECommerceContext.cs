using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace e_commerce
{
    class ECommerceContext :DbContext
    {
        public DbSet<CarritoDeCompras> CarritoDeCompras { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-M2Q3GI4;Database=ECommerceDB;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ECommerceDB;Trusted_Connection=True;");
        }

    }
}
