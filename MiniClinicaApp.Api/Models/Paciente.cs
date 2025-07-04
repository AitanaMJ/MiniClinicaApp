﻿using System.ComponentModel.DataAnnotations;
using MiniClinicaApp.Api.Models;

namespace MiniClinicaApp.Api.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        public string NombreyApellido { get; set; } = "";
        public int Edad { get; set; }
        public int dni { get; set; }

        
    }
}
