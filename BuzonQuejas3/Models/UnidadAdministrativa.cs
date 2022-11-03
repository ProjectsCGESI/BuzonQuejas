using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuzonQuejas3.Models
{
    public class UnidadAdministrativa
    {
        public Guid UnidadAdministrativaID { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Debe llenar este campo")]
        public String Nombre { get; set; }
    }
}
