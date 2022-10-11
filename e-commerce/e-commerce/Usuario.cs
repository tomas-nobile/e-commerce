﻿using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce
{
    class Usuario
    {   // de esta clase usuario derivan las clases Vendedor y Cliente
        private int dni { get; set; }
        private String nombre { get; set; }
        private String apellido { get; set; }
        private String mail { get; set; }
        private int telefono { get; set; }
        public Usuario()
        {   // constructor por defecto sin valores
            this.dni = 0;
            this.nombre = "sin valor";
            this.apellido = "sin valor";
            this.mail = "sin valor";
            this.telefono = 0;
        }
        public Usuario(int dni, string nombre, string apellido, string mail, int telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;
        }
        public Usuario(int dni, string nombre, string apellido, string mail)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = 0; /* se me ocurrió que tenga un telefono para una "mayor seguridad" en la cuenta del usuario 
                                * pero lo dejé como algo opcional de momento
                                */
        }
    }
}
