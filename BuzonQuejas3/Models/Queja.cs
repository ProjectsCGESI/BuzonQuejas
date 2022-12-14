using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BuzonQuejas3.Models
{
    public partial class Queja
    {
        public Guid QuejaID { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(13)]
        public string Folio { get; set; }
        
        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string NombreQuejante { get; set; }
        
        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string ApellidoPQuejante { get; set; }
        
        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string ApellidoMQuejante { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(100)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(40)]
        //[DataType(DataType.EmailAddress,]
        [EmailAddress(ErrorMessage = "Ingresa un correo electrónico con el formato correcto")]

        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        //[StringLength(400)]
        public string RelatoHechos { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string NombreServidor { get; set; }
        
        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string ApellidoPServidor { get; set; }
        
        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string ApellidoMServidor { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [Display(Name = "Fecha de creación")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(20)]
        public string Estatus { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public DateTime FechaAtencion { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string NombreAtendio { get; set; }
        
        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string ApellidoPAtendio { get; set; }
        
        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(50)]
        public string ApellidoMAtendio { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(300)]
        public string Resolucion { get; set; }
        
        [StringLength(300)]
        public string NumeroPrevio { get; set; }

        //Llave foranea Departamento
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid DepartamentoID { get; set; }

        [ForeignKey("DepartamentoID")]
        public Departamento Departamento { get; set; }

        //Llave foranea Municipio
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid MunicipioID { get; set; }

        [ForeignKey("MunicipioID")]
        public Municipio Municipio{ get; set; }

        //Llave foranea UnidadAdministrativa
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid UnidadAdministrativaID { get; set; }

        [ForeignKey("UnidadAdministrativaID")]
        public UnidadAdministrativa UnidadAdministrativa { get; set; }
        
        //Llave foranea Medio
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid MedioID { get; set; }

        [ForeignKey("MedioID")]
        public Medio Medio { get; set; }
        
        //Llave foranea Cargo
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid CargoID { get; set; }

        [ForeignKey("CargoID")]
        public Cargo Cargo { get; set; }
        
        //Llave foranea Motivo
        [Required(ErrorMessage = "Debe llenar este campo")]
        public Guid MotivoID { get; set; }

        [ForeignKey("MotivoID")]
        public Motivo Motivo { get; set; }

    }
}
