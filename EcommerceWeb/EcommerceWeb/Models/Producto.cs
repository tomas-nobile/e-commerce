using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWeb.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Precio:")]
        [Required(ErrorMessage = "Es requerido un precio para subir su producto")]
        public double Precio { get; set; }
        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Es requerido un nombre para subir su producto")]
        public String Nombre { get; set; }
        [Display(Name = "Descripción:")]
        public String Descripcion { get; set; } //descripción opcional por parte del cliente
        // - (necesario) agregar foto / fotos del producto
        // - (opcional) agregarle la fecha de publicación del producto; ejemplo en el pdf "Mas sobre MVC..."
    }
}
