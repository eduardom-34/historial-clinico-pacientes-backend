using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Apellidos es Requerido")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Apellidos deber ser minimo 1 y max 60 caractereses")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Nombre es Requerido")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Nombre deber ser minimo 1 y max 60 caractereses")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Direccion es Requerido")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Direccion deber ser minimo 1 y max 100 caractereses")]
        public string Direccion { get; set; }

        [StringLength(40, MinimumLength = 1, ErrorMessage = "Telefono deber ser minimo 1 y max 40 caractereses")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Genero es Requerido")]
        public char Genero { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public HistoriaClinica HistoriaClinica { get; set; }
    }
}
