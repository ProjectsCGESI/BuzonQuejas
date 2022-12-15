using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuzonQuejas3.Models
{
    public class Usuario
    {
        public Guid UsuarioID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string Clave { get; set; }

        public bool Activo { get; set; }

        //Llave foranea unidad remitente
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid UnidadRemitenteID { get; set; }

        [ForeignKey("UnidadRemitenteID")]
        public UnidadRemitente UnidadRemitente { get; set; }

        //Llave foranea Rol
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid RolID { get; set; }

        [ForeignKey("RolID")]
        public Rol Rol { get; set; }
        
        //Llave foranea Unidad Administrativa
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid UnidadAdministrativaID { get; set; }

        [ForeignKey("UnidadAdministrativaID")]
        public UnidadAdministrativa UnidadAdministrativa { get; set; }
    }
}
