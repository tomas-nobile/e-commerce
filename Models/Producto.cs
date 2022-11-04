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
        [Range(1, Int32.MaxValue, ErrorMessage = "No se puede ingresar un valor negativo")]
        public double Precio { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Es requerido un nombre para subir su producto")]
        public String Nombre { get; set; }

        [Display(Name = "Descripción:")]
        public String Descripcion { get; set; }
        /*
        - (necesario) agregar foto / fotos del producto //proyecto cupcakes, grabar ruta imagen, getImage()*****
        - (opcional) agregarle la fecha de publicación del producto; ejemplo en el pdf "Mas sobre MVC..."
        - al crear un producto, que la fecha se ponga sola por ej
       
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de subida:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; }
        */
    }
}
