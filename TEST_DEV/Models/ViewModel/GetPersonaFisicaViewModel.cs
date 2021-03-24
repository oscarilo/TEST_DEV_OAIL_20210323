using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEST_DEV.Models.ViewModel
{
    public class GetPersonaFisicaViewModel
    {

        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string RFC { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }

    }// class

}// namespace