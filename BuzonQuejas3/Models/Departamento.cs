﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuzonQuejas3.Models
{
    public class Departamento
    {
        public Guid DepartamentoID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Debe llenar este campo")]
        public String Nombre { get; set; }
    }
}
