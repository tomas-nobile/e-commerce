using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce
{
    class Producto
    {
        public int idProducto { get; set; }
        public double precio { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; } /* seguramente los productos tengan muchos mas detalles que podemos agregar o
                                                  * simplemente unirlos todos en la misma descripción brindada por el vendedor
                                                  */
        public Producto()
        {
            this.idProducto = 0; // estoy pensando en que los IDs deberian ser static para que cada objeto tenga uno que lo identifique
            this.precio = 0;
            this.nombre = "sin valor";
            this.descripcion = "sin valor";
        }
        public Producto(int idNumerico, double precio, string nombre, string descripcion)
        {
            this.idProducto = idNumerico;
            this.precio = precio;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
