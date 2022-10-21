using System;

namespace e_commerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user= Usuario.agregarUsuario(42077878,"tomas","nobile","nobiletomas@gmail.com",1169008951);

            user.agregarProducto(100, "balon", "pelota de basket");

            user.agregarProductoCarrito(2);
        }
    }
}
