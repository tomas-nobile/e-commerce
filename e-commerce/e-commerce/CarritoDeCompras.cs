using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce
{
    class CarritoDeCompras
    {
        public int idNumericoDeCompra { get; set; }
        public Producto producto { get; set; }
        public CarritoDeCompras()
        {
            this.idNumericoDeCompra = 0;
        }
        public CarritoDeCompras(int idNumericoDeCompra)
        {
            this.idNumericoDeCompra = idNumericoDeCompra;
        }
    }
}
