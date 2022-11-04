using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace EcommerceWeb.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "DNI:")]
        [Required(ErrorMessage = "Es requerido un DNI para crear un usuario")]
        public int DNI { get; set; }
        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Es requerido un nombre para crear un usuario")]
        public String nombre { get; set; }
        [Display(Name = "Apellido:")]
        [Required(ErrorMessage = "Es requerido un apellido para crear un usuario")]
        public String Apellido { get; set; }
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Es requerido un email para crear un usuario")]
        public String Email { get; set; } 
    }
}
