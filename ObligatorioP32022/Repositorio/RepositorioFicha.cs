using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repositorio
{
    public class RepositorioFicha : IRepositorioFicha
    {
        private IDbConnection _con;

        public RepositorioFicha(IDbConnection con)
        {
            _con = con;
        }

        public IEnumerable Buscar(int id, string texto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Get()
        {
            ICollection<FichaCuidado> result = new List<FichaCuidado>();
            IDbCommand command = _con.CreateCommand();
            command.CommandText = "select * from FichaCuidado";
            try
            {
                _con.Open();


                using IDataReader reader = command.ExecuteReader();
                FichaCuidado fichaCuidado = null;
                while (reader.Read())
                {
                    fichaCuidado = new FichaCuidado();
                    fichaCuidado.idFicha = (int)reader["id"];
                    fichaCuidado.miPlanta = (Planta)reader["idPlanta"];
                    fichaCuidado.FrecuenciaRiego = (string)reader["frecuenciaRiego"];
                    fichaCuidado.TipoIluminacion = (string)reader["tipoIluminacion"];
                    fichaCuidado.Temperatura = (int)reader["temperatura"];
                    result.Add(fichaCuidado);
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

        public FichaCuidado getByID(int pd)
        {
            throw new NotImplementedException();
        }

        public bool Insert(FichaCuidado obj)
        {
            bool success = false;

            IDbCommand command = _con.CreateCommand();
            command.CommandText = @"insert into FichaCuidado values (@idPlanta,@frecuenciaRiego,@tipoIluminacion,@temperatura)";
            command.Parameters.Add(new SqlParameter("@idPlanta", obj.miPlanta.IdPlanta));
            command.Parameters.Add(new SqlParameter("@frecuenciaRiego", obj.FrecuenciaRiego));
            command.Parameters.Add(new SqlParameter("@tipoIluminacion", obj.TipoIluminacion));
            command.Parameters.Add(new SqlParameter("@temperatura", obj.Temperatura));


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

        public void Update(FichaCuidado obj)
        {
            throw new NotImplementedException();
        }
    }
}
