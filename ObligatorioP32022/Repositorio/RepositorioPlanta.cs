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
    public class RepositorioPlanta : IRepositorioPlanta
    {

        private IDbConnection _con;

        public RepositorioPlanta(IDbConnection con)
        {
            _con = con;
        }
        public bool Delete(int id)
        {/*
            SqlCommand oComando = new SqlCommand("BajaPlanta");
            oComando.Connection = (SqlConnection)_con;
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
            }*/
            return true;
        }

        public IEnumerable Get()
        {
            ICollection<Planta> result = new List<Planta>();
            IDbCommand command = _con.CreateCommand();
            command.CommandText = "select * from plantas";
            //ommand.CommandType = CommandType.StoredProcedure;
            try
            {
                _con.Open();


                using IDataReader reader = command.ExecuteReader();
                Planta miPlanta = null;
                while (reader.Read())
                {
                    TipoPlanta miTipo = new TipoPlanta();
                    RepositorioTipo miRepo = new RepositorioTipo(new Repositorio.Conexion());


                   
                    miPlanta = new Planta(); 
                    miTipo.id = (int)reader["tipo"];
                    miPlanta.IdPlanta = (int)reader["id"];
                    miPlanta.MiTipoPlanta = miRepo.getByID(miTipo.id);

                    miPlanta.NombreCientifico = (string)reader["nombreCientifico"];
                    miPlanta.NombreVulgar = (string)reader["nombresVulgares"];
                    miPlanta.Descripcion = (string)reader["descripcion"];
                    miPlanta.Ambiente = (string)reader["ambiente"];
                    miPlanta.AlturaMax = Convert.ToInt64(reader["alturaMax"]);
                    miPlanta.Precio = Convert.ToInt64(reader["precioUnitario"]);
                    result.Add(miPlanta);
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

        public Planta getByID(int id)
        {
            Planta miPlanta = null;
            IDbCommand command = _con.CreateCommand();

           command.CommandText = @"select * from Plantas where id like @id";
           command.Parameters.Add(new SqlParameter("@id", id));
            try
            {
                _con.Open();


                using IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    miPlanta = new Planta();
                    miPlanta.IdPlanta = (int)reader["id"];
                    miPlanta.NombreCientifico = (string)reader["nombreCientifico"];
                    miPlanta.NombreVulgar = (string)reader["nombresVulgares"];
                    miPlanta.Descripcion = (string)reader["descripcion"];
                    miPlanta.Ambiente = (string)reader["ambiente"];
                    miPlanta.AlturaMax = Convert.ToInt64(reader["alturaMax"]);
                    miPlanta.Precio = Convert.ToInt64(reader["precioUnitario"]);
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
            return miPlanta;
        }

        public bool Insert(Planta obj)
        {
            bool success = false;
            IDbCommand command = _con.CreateCommand();
            command.CommandText = @"insert into Plantas values (@tipo,@nombreCientifico,@nombresVulgares,@descripcion,@ambiente,@alturaMax,@precioUnitario)";
            command.Parameters.Add(new SqlParameter("@tipo", obj.MiTipoPlanta.id));
            command.Parameters.Add(new SqlParameter("@nombreCientifico", obj.NombreCientifico));
            command.Parameters.Add(new SqlParameter("@nombresVulgares", obj.NombreVulgar));
            command.Parameters.Add(new SqlParameter("@descripcion", obj.Descripcion));
            command.Parameters.Add(new SqlParameter("@ambiente", obj.Ambiente));
            command.Parameters.Add(new SqlParameter("@alturaMax", obj.AlturaMax));
            command.Parameters.Add(new SqlParameter("@precioUnitario", obj.Precio));
           

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
        public void Update(Planta obj)
        {
            SqlCommand oComando = new SqlCommand("ModificarPlanta", (SqlConnection)_con);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _nombrec = new SqlParameter("@nombreCientifico ", obj.NombreCientifico);
            SqlParameter _tipo = new SqlParameter("@tipoPlanta ", obj.MiTipoPlanta);
            //SqlParameter _fc = new SqlParameter("@tipoPlanta ", obj.MiFichaCuidado);
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
            //oComando.Parameters.Add(_fc);
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


        public IEnumerable Buscar(int id, string texto)
        {
            ICollection<Planta> result = new List<Planta>();
            IDbCommand command = _con.CreateCommand();

            switch (id)
            {
                case 0:
                    command.CommandText = @"select * from Plantas where nombreCientifico like @nombreCientifico";
                    command.Parameters.Add(new SqlParameter("@nombreCientifico", texto));
                    break;
                case 1:
                    command.CommandText = @"select * from Plantas where nombresVulgares like @nombresVulgares";
                    command.Parameters.Add(new SqlParameter("@nombresVulgares", texto));
                    break;
                case 2:
                    command.CommandText = @"select * from Plantas p, TipoPlanta tp where p.tipo = tp.id and tp.nombre = @tipoPlanta";
                    command.Parameters.Add(new SqlParameter("@tipoPlanta", texto));
                    break;
                case 3:
                    command.CommandText = @"select * from Plantas where ambiente like @ambiente";
                    command.Parameters.Add(new SqlParameter("@ambiente", texto));
                    break;
                case 4:
                    command.CommandText = @"select * from Plantas where alturaMax < @alturaMax";
                    command.Parameters.Add(new SqlParameter("@alturaMax", texto));
                    break;
                case 5:
                    command.CommandText = @"select * from Plantas where alturaMax > @alturaMax";
                    command.Parameters.Add(new SqlParameter("@alturaMax", texto));
                    break;
                default:
                    command.CommandText = "select * from dbo.Plantas";
                    break;



            }
            try
            {
                _con.Open();


                using IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TipoPlanta miTipo = new TipoPlanta();
                    Planta miPlanta = new Planta();
                    RepositorioTipo miRepo= new RepositorioTipo(new Repositorio.Conexion());

                    miTipo.id = (int)reader["tipo"];
                    miPlanta.IdPlanta = (int)reader["id"];
                    miPlanta.NombreCientifico = (string)reader["nombreCientifico"];
                    miPlanta.NombreVulgar = (string)reader["nombresVulgares"];
                    miPlanta.Descripcion = (string)reader["descripcion"];
                    miPlanta.Ambiente = (string)reader["ambiente"];
                    miPlanta.AlturaMax = Convert.ToInt64(reader["alturaMax"]);
                    miPlanta.Precio = Convert.ToInt64(reader["precioUnitario"]);
                    miPlanta.MiTipoPlanta = miRepo.getByID(miTipo.id);


                    result.Add(miPlanta);
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

        public IEnumerable BuscarPlanta(int id, string texto)
        {
            throw new NotImplementedException();
        }

        public bool GuardarImagen(IFormFile imagen, Planta planta)
        {
            throw new NotImplementedException();
        }

    }
}