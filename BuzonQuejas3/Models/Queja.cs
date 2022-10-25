using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BuzonQuejas3.Models
{
    public partial class Queja
    {
        public Guid IdQueja { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string NombreCreador { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string MotivoQueja { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string RelatoHechos { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string ServidorInvolucrado { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [Display(Name = "Asignado a")]
        public string DepartamentoAsignado { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [Display(Name = "Fecha de creación")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Estatus { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public DateTime FechaAtencion { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string AtendidoPor { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public string Resolucion { get; set; }

        //public String DepartamentoID { get; set; }


    }
}
