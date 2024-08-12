﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces.IRepositorio
{
    public interface IRepositorioGenerico<T> where T : class
    {
        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T, bool>> Filtro = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            string incluirPropiedades = null // Include
            );

        Task<T> ObtenerPrimero(
            Expression<Func<T, bool>> Filtro = null,
            string incluirPropiedades = null // Include
            );

        Task Agregar(T entidad);
        void Remove(T entidad);
    }
}
