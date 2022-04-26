using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repositorio
{
    public class RepositorioTipo : IRepositorioTipo
    {


        private IDbConnection _con;

        public RepositorioTipo(IDbConnection con)
        {
            _con = con;
        }
        public void Delete(int id)
        {
            bool success = false;

            IDbCommand command = _con.CreateCommand();
            command.CommandText = @"delete from TipoPlanta where id = @id";
            command.Parameters.Add(new SqlParameter("@id", id));


            try
            {
                _con.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: {0}", ex.Message));
            }
            finally
            {
                if (_con != null)
                {
                    _con.Close();
                    _con.Dispose();
                }
            }
        }
        public IEnumerable BuscarPlanta(int id, string texto)
        {
            throw new NotImplementedException();
        }


        public IEnumerable Get()
        {
            ICollection<TipoPlanta> result = new List<TipoPlanta>();
            IDbCommand command = _con.CreateCommand();
            command.CommandText = "select * from TipoPlanta";
            //ommand.CommandType = CommandType.StoredProcedure;
            try
            {
                _con.Open();


                using IDataReader reader = command.ExecuteReader();
                TipoPlanta miTipo = null;
                while (reader.Read())
                {
                    miTipo = new TipoPlanta();
                    miTipo.id = (int)reader["id"];
                    miTipo.NombreUnico = (string)reader["nombre"];
                    miTipo.DescripcionTipo = (string)reader["descripcion"];
                    result.Add(miTipo);
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
                    _con.Dispose();
                }
            }
            return result;
        }

        public TipoPlanta getByID(int pd)
        {
            TipoPlanta miTipo = null;
            IDbCommand command = _con.CreateCommand();

            command.CommandText = @"select * from TipoPlanta where id like @id";
            command.Parameters.Add(new SqlParameter("@id", pd));
            try
            {
                _con.Open();


                using IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    miTipo = new TipoPlanta();
                    miTipo.id = (int)reader["id"];
                    miTipo.NombreUnico = (string)reader["nombre"];
                    miTipo.DescripcionTipo = (string)reader["descripcion"];
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
                    _con.Dispose();
                }
            }
            return miTipo;
        }

        public bool Insert(TipoPlanta obj)
        {
            bool success = false;
            IDbCommand command = _con.CreateCommand();
            command.CommandText = @"insert into TipoPlanta values (@nombre,@descripcion)";
            command.Parameters.Add(new SqlParameter("@nombre", obj.NombreUnico));
            command.Parameters.Add(new SqlParameter("@descripcion", obj.DescripcionTipo));


            try
            {
                _con.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: {0}", ex.Message));
            }
            finally
            {
                if (_con != null)
                {
                    _con.Close();
                    _con.Dispose();
                }
            }
            return success;
        }

        public void Update(TipoPlanta obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Buscar(int id, string texto)
        {
            throw new NotImplementedException();
        }

    }
}
