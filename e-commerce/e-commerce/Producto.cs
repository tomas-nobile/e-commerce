using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce
{
    class Producto
    {
        public int id { get; set; }
        public double precio { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; } /* seguramente los productos tengan muchos mas detalles que podemos agregar o
        
                                                 * simplemente unirlos todos en la misma descripción brindada por el vendedor
                                                  */
        public Producto()
        {
            this.precio = 0;
            this.nombre = "sin valor";
            this.descripcion = "sin valor";
        }
        public Producto(double precio, string nombre, string descripcion)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
