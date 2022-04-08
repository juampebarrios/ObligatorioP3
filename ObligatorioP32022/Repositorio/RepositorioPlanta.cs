using Dominio;
using Persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Repositorio
{
    public class RepositorioPlanta : IRepositorioPlanta
    {

        private SqlConnection _con;
        public RepositorioPlanta(SqlConnection con)
        {
            _con = con;
        }
        public void Delete(int id)
        {
            SqlCommand oComando = new SqlCommand("BajaPlanta", _con);//Modificar nompre SP
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _nombre = new SqlParameter("@id", id);
            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;

            int oAfectados = -1;

            oComando.Parameters.Add(_nombre);
            oComando.Parameters.Add(_Retorno);
            try
            {
                _con.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("No se pudo eliminar");
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
        }

        public IEnumerable Get()
        {

            ICollection<Planta> result = new List<Planta>();
            IDbCommand command = _con.CreateCommand();
            command.CommandText = "select * from Planta";
            try
            {
                _con.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    Planta miPlanta = null;
                    while (reader.Read())
                    {
                        miPlanta = new Planta();
                        miPlanta.NombreCientifico = (string)reader["nombreCientifico "];
                        miPlanta.NombreVulgar = (string)reader["nombresVulgares "];
                        miPlanta.Descripcion = (string)reader["descripcion "];
                        miPlanta.Ambiente = (string)reader["ambiente "];
                        miPlanta.AlturaMax = (double)reader["alturaMax "];
                        miPlanta.Precio = (double)reader["precioUnitario "];
                        miPlanta.Foto = (string)reader["foto "];
                        result.Add(miPlanta);
                    }

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

        public Planta getByID(int pd)
        {
            Planta miPlanta = null;
            SqlCommand oComando = new SqlCommand("Exec  BuscarPlanta " + "'" + pd + "'", _con);

            SqlDataReader reader;

            try
            {
                _con.Open();
                reader = oComando.ExecuteReader();
                if (reader.Read())
                {
                    miPlanta = new Planta();
                    miPlanta.NombreCientifico = (string)reader["nombreCientifico "];
                    miPlanta.NombreVulgar = (string)reader["nombresVulgares "];
                    miPlanta.Descripcion = (string)reader["descripcion "];
                    miPlanta.Ambiente = (string)reader["ambiente "];
                    miPlanta.AlturaMax = (double)reader["alturaMax "];
                    miPlanta.Precio = (double)reader["precioUnitario "];
                    miPlanta.Foto = (string)reader["foto "];
                }
                reader.Close();
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
            return miPlanta;
        }

        public void Insert(Planta obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Planta obj)
        {
            SqlCommand oComando = new SqlCommand("ModificarPlanta", _con);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _nombrec = new SqlParameter("@nombreCientifico ", obj.NombreCientifico);
            SqlParameter _tipo = new SqlParameter("@tipoPlanta ", obj.MiTipoPlanta);
            SqlParameter _fc = new SqlParameter("@tipoPlanta ", obj.MiFichaCuidado);
            SqlParameter _nombrev = new SqlParameter("@nombresVulgares ", obj.NombreVulgar);
            SqlParameter _desc = new SqlParameter("@descripcion ", obj.Descripcion);
            SqlParameter _ambiente = new SqlParameter("@ambiente ", obj.Ambiente);
            SqlParameter _alt = new SqlParameter("@alturaMax ", obj.AlturaMax);
            SqlParameter _precio = new SqlParameter("@precioUnitario ", obj.Precio);
            SqlParameter _foto = new SqlParameter("@foto", obj.Foto);
            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;

            int oAfectados = -1;

            oComando.Parameters.Add(_nombrec);
            oComando.Parameters.Add(_tipo);
            oComando.Parameters.Add(_fc);
            oComando.Parameters.Add(_nombrev);
            oComando.Parameters.Add(_desc);
            oComando.Parameters.Add(_ambiente);
            oComando.Parameters.Add(_alt);
            oComando.Parameters.Add(_precio);
            oComando.Parameters.Add(_foto);
            oComando.Parameters.Add(_Retorno);

            try
            {
                _con.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("No se pudo modificar");
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
    }
}
