using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BuzonQuejas3.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Clave { get; set; }
        public string Rol { get; set; }
    }
}
