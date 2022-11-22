using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuzonQuejas3.Models
{
    public class UsuarioMostrar
    {
        public Guid UsuarioID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string Correo { get; set; }
        public bool Activo { get; set; }

        public string Departamento { get; set; }

        public string Rol { get; set; }

        public string UnidadAdministrativa { get; set; }
    }
}
