using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class RegistroDto
    {
        [Required(ErrorMessage = "Username es requerido")]
        public string Username {  get; set; }

        [Required(ErrorMessage = "Password es requerido")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "El password deber ser minimo 4 y max de 10 caracteres")]
        public string Password {  get; set; }

        [Required(ErrorMessage = "Apellidos es Requerido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Nombres es Requerido")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Email es Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rol es requerido")]
        public string Rol {  get; set; }
    }
}
