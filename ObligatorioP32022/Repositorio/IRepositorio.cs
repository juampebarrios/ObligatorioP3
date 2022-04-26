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
        bool Delete(int id);
        void Update(T obj);
        IEnumerable Buscar(int id, string texto);
    }
}