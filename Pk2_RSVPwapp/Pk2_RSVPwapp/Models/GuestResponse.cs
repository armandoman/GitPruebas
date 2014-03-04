using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
//Usado para validar campos
using System.ComponentModel.DataAnnotations;


namespace Pk2_RSVPwapp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage= "Porfavor ingrese su nombre:")]
         public string Name { get; set; }

        [Required(ErrorMessage= "Por favor ingrese su correo electronico.")]
        [RegularExpression(".+\\@..+",
            ErrorMessage= "Favor ingresar una cuenta de correo valida")]
        public string Email { get; set; }

        [Required(ErrorMessage= "Por favor ingrese su numero telefonico.")]
        public string Phone { get; set; }

        [Required(ErrorMessage= "Por favor especifique si asistira o no.")]
        public bool? WillAttend { get; set; }
    }
}