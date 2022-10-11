using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce
{
    class CarritoDeCompras
    {
        private int idNumericoDeCompra { get; set; }
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
