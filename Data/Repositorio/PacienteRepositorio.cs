using Data.Interfaces.IRepositorio;
using Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public class PacienteRepositorio : Repositorio<Paciente>, IPacienteRepositorio
    {
        private readonly ApplicationDbContext _db;

        public PacienteRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Paciente paciente)
        {
            var pacienteDb = _db.Pacientes.FirstOrDefault(e => e.Id == paciente.Id);
            if(pacienteDb != null)
            {
                pacienteDb.Apellidos = pacienteDb.Apellidos;
                pacienteDb.Nombres = pacienteDb.Nombres;
                pacienteDb.Estado = pacienteDb.Estado;
                pacienteDb.FechaActualizacion = DateTime.Now;
                pacienteDb.Telefono = pacienteDb.Telefono;
                pacienteDb.Genero = pacienteDb.Genero;
                pacienteDb.ActualizadoPorId = pacienteDb.ActualizadoPorId;
                pacienteDb.Direccion = pacienteDb.Direccion;
                _db.SaveChanges();
            }
        }
    }
}
