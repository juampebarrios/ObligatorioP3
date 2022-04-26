using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repositorio
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private IDbConnection _con;

        public RepositorioUsuario(IDbConnection con)
        {
            _con = con;
        }

        public IEnumerable Buscar(int id, string texto)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Get()
        {
            throw new NotImplementedException();
        }

        public Usuario getByID(int pd)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string usu, string pass)
        {
            Usuario miUsu = null;
            IDbCommand command = _con.CreateCommand();

            command.CommandText = @"select * from Usuario where usuario = @usuario and pass = @pass";
            command.Parameters.Add(new SqlParameter("@usuario", usu));
            command.Parameters.Add(new SqlParameter("@pass", pass));
            try
            {
                _con.Open();


                using IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    miUsu = new Usuario();
                    miUsu.IdUsuario = (int)reader["id"];
                    miUsu.Email = (string)reader["usuario"];
                    miUsu.Password = (string)reader["password"];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error: {0}", e.Message));
            }
            finally
            {
                if (_con != null)
                {
                    _con.Close();
                }
            }
            return miUsu;
        }

        public bool Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
