using Dominio;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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


        public bool Delete(int id)
        {
            bool success = false;

            IDbCommand command1 = _con.CreateCommand();
            command1.CommandText = @"exec spEliminarTipo @id";

            command1.Parameters.Add(new SqlParameter("@id", id));
            //command.CommandText = @"exec spEliminarTipo idTipo = @id";


            try
            {
                _con.Open();
                int afectado = command1.ExecuteNonQuery();
                if (afectado == -1)
                {
                    throw new Exception("No se borro");
                }
                else 
                {
                    success = true;
                }
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
                }
            }
            return success;
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
            IDbCommand command = _con.CreateCommand();
            command.CommandText = @"UPDATE TipoPlanta SET descripcion = @descripcion WHERE id = @id";
            command.Parameters.Add(new SqlParameter("@id", obj.id));
            command.Parameters.Add(new SqlParameter("@descripcion", obj.DescripcionTipo));

            try
            {
                _con.Open();
                int filasAfectadas = command.ExecuteNonQuery();
                if (filasAfectadas == 0)
                    throw new Exception("no se modifico");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (_con != null)
                {
                    _con.Close();
                    _con.Dispose();
                }
                if (command != null)
                    command.Dispose();
            }
        }

        public IEnumerable Buscar(int id, string texto)
        {
            throw new NotImplementedException();
        }

    }
}
