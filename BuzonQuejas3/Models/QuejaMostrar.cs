using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuzonQuejas3.Models
{
    public class QuejaMostrar
    {
        public Guid QuejaID { get; set; }
        public string Folio { get; set; }
        public string NombreQuejante { get; set; }
        public string ApellidoPQuejante { get; set; }
        public string ApellidoMQuejante { get; set; }
        //public string Telefono { get; set; }
        //public string Correo { get; set; }
        public string MotivoQueja { get; set; }
        //public string RelatoHechos { get; set; }
        public string NombreServidor { get; set; }
        public string ApellidoPServidor { get; set; }
        public string ApellidoMServidor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estatus { get; set; }
        //public DateTime FechaAtencion { get; set; }
        //public string AtendidoPor { get; set; }
        //public string Resolucion { get; set; }
        public Guid DepartamentoID { get; set; }
        public Guid MedioID { get; set; }
        public string Medio { get; set; }

        //public Guid MunicipioID { get; set; }
        //public Guid UnidadAdministrativaID { get; set; }
        //public string UnidadAdministrativa { get; set; }
        //public Guid CentroTrabajoID { get; set; }
    }
}
