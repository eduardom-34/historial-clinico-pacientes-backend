﻿using Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios.Interfaces
{
    public interface IMedicoServicio
    {
        Task<IEnumerable<MedicoDto>> ObtenerTodos();
        Task<MedicoDto> Agregar(MedicoDto medicoDto);
        Task Actualizar(MedicoDto medicoDto);
        Task Remover(int id);
    }
}
