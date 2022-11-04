using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWeb.Models;

namespace EcommerceWeb.Context
{
    public class WebDatabaseContext : DbContext
    {
        public WebDatabaseContext(DbContextOptions<WebDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<CarritoDeCompras> Carritos { get; set; }
    }
}

