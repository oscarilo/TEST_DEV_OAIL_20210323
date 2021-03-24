using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TEST_DEV.Models.ViewModel
{
    public class PostPersonaFisicaViewModel
    {
        
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        [Required]
        [Display(Name ="Nombre:")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Apellido paterno:")]
        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [Display(Name = "Apellido materno:")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Display(Name = "RFC:")]
        [StringLength(13)]
        public string RFC { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento:")]
        public DateTime FechaNacimiento { get; set; }
        public int UsuarioAgrega { get; set; }
        public bool Activo { get; set; }

    }// class

}// namespace