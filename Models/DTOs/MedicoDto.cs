﻿using Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Models.DTOs
{
    public class MedicoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Apellido es Requerido")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Apellidos deber ser Minimo 1 y maximo de 60 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Nombre es Requerido")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Apellidos deber ser Minimo 1 y maximo de 60 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Direccion es Requerido")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Apellidos deber ser Minimo 1 y maximo de 100 caracteres")]
        public string Direccion { get; set; }

        [MaxLength(40)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Genero es Requerido")]
        public char Genero { get; set; }

        [Required(ErrorMessage = "Especialidad es Requerido")]
        public int EspecialidadId { get; set; }


        public string NombreEspecialidad { get; set; }

        public int Estado { get; set; }
    }
}
