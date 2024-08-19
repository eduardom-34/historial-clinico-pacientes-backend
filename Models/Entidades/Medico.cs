using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    public class Medico
    {
        [Key]
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

        [Required(ErrorMessage = "Especialidad es Requerida")]
        public int EspecialidadId { get; set; }

        [ForeignKey("EspecialidadId")]
        public Especialidad Especialidad { get; set; }

        public bool Estado {  get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion{ get; set; }

    }
}
