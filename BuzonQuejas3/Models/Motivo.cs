using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BuzonQuejas3.Models
{
    public class Motivo
    {
        public Guid MotivoID { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(100)]
        public string Descripcion { get; set; }

        //Llave foranea UnidadAdministrativa
        public Guid? UnidadAdministrativaID { get; set; }

        [ForeignKey("UnidadAdministrativaID")]
        public UnidadAdministrativa UnidadAdministrativa { get; set; }
    }
}
