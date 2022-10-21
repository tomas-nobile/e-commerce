using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_commerce
{
    class Usuario
    {   // de esta clase usuario derivan las clases Vendedor y Cliente
        public int id { get; set; }
        public CarritoDeCompras carrito { get; set; }
        public int dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String mail { get; set; }
        public int telefono { get; set; }
        public List<Producto> productos { get; set; }

        public Usuario()
        {   // constructor por defecto sin valores
            this.dni = 0;
            this.nombre = "sin valor";
            this.apellido = "sin valor";
            this.mail = "sin valor";
            this.telefono = 0;
            this.carrito = new CarritoDeCompras();
            this.productos = new List<Producto>();
        }
        public Usuario(int dni, string nombre, string apellido, string mail, int telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;
            this.carrito = new CarritoDeCompras();
            this.productos = new List<Producto>();
        }

        public static Usuario agregarUsuario(int dni, string nombre, string apellido, string mail, int telefono)
        {
            using (var context = new ECommerceContext())
            {
                Usuario usuario = new Usuario(dni, nombre, apellido, mail,telefono);

                context.Usuario.Add(usuario);
                context.SaveChanges();


                return usuario;
            }
        }

        public void agregarProducto(double precio, string nombre, string descripcion)
        {
            using (var context = new ECommerceContext())
            {
                Producto producto = new Producto(precio, nombre, descripcion);
               
                this.productos.Add(producto);

                context.Usuario.Update(this);
                
                context.SaveChanges();
            }
        }


        public void borrarProducto(int id)
        {
            using (var context = new ECommerceContext())
            {
                Producto producto = context.Producto.Where(p =>
                p.id == id).FirstOrDefault<Producto>();

                context.Producto.Remove(producto);
                context.SaveChanges();
            }
        }

        public void agregarProductoCarrito(int id)
        {
            using (var context = new ECommerceContext())
            {
                Producto producto = context.Producto.Where(p => p.id == id).FirstOrDefault<Producto>();
                
                this.carrito.agregarProducto(producto);
            }
        }


        public void eliminarProductoCarrito(int id)
        {
            using (var context = new ECommerceContext())
            {
                Producto producto = context.Producto.Where(p => p.id == id).FirstOrDefault<Producto>();

                this.carrito.agregarProducto(producto);
            }
        }


    }
}
