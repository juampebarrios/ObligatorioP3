using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public interface IRepositorio<T>
    {
        IEnumerable Get();
        T getByID(int pd);
        bool Insert(T obj);
        void Delete(int id);
        void Update(T obj);
        IEnumerable BuscarPlanta(int id, string texto);
    }
}
