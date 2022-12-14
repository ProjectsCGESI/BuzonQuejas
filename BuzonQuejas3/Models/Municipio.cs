using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuzonQuejas3.Models
{
    public class Municipio
    {
        public Guid MunicipioID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Debe llenar este campo")]
        public String Nombre { get; set; }
    }
}
