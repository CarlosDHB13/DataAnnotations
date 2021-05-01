using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class Class1
    {
        [Display(Name ="Nombre")]
        [Required]
        [StringLength(10)]
        [MinLength(5)]
        [NameExistAtribute(ErrorMessage ="El nombre escrito ya existe en la base de datos")]
        public string Nombre { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Display(Name = "Edad")]
        [Required]
        [Range(18, 55, ErrorMessage ="La edad debe ser de 18 a 55 años")]
        public string Edad { get; set; }

        [Display(Name = "Código")]
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage= "Solo se aceptan letras")]
        public string Codigo { get; set; }

        [Display(Name = "Precio")]
        [Required]
        [Range(2.10, 100.05, ErrorMessage = "El precio debe ser entre 2.10 a 100.05")]
        [PrecioExistAtribute(ErrorMessage = "El Precio no debe ser 2.13")]
        public string Precio { get; set; }


        [Display(Name = "Contraseña")]
        [Required]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }


        [Display(Name = "Confirmar Contraseña")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Contrasena", ErrorMessage ="Contraseña y confirmar contraseña deben ser iguales")]
        public string ConfirmContra { get; set; }


    }

    public class NameExistAtribute : ValidationAttribute
    {
        IList<string> list = new List<string>() {"pepe", "julian", "mario"};
        public override bool IsValid(object value)
        {
            if (list.Contains(value))
                return false;
            return true;
        }
    }

    public class PrecioExistAtribute : ValidationAttribute
    {
        IList<string> list = new List<string>() { "2.13", "55" };
        public override bool IsValid(object value)
        {
            if (list.Contains(value))
                return false;
            return true;
        }
    }

}