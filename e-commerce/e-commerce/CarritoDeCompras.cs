using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce
{
    class CarritoDeCompras
    {
        public int id  { get; set; }
        public Producto producto { get; set; }



        public void agregarProducto(Producto producto)
        {
            using (var context = new ECommerceContext())
            {
                this.producto= producto;
 
                context.CarritoDeCompras.Update(this);
                context.SaveChanges();
            }
        }

        public void borrarProducto()
        {
            using (var context = new ECommerceContext())
            {
                this.producto = null;

                context.CarritoDeCompras.Update(this);
                context.SaveChanges();
            }
        }
    }
}
