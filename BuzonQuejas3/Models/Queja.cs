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
        [StringLength(100)]
        public string NombreQuejante { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(100)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(30)]
        //[DataType(DataType.EmailAddress,]
        [EmailAddress(ErrorMessage = "Ingresa un correo electrónico con el formato correcto")]

        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(200)]
        public string MotivoQueja { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(400)]
        public string RelatoHechos { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(100)]
        public string ServidorInvolucrado { get; set; }

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
        [StringLength(100)]
        public string AtendidoPor { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [StringLength(300)]
        public string Resolucion { get; set; }

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

    }
}
