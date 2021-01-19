using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaEscritorio.Entidad;
using System.Data;
using System.Data.SqlClient;

namespace SistemaEscritorio.Datos
{
    public class PersonaDatos
    {
        //metodo listar 
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Persona_S", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }

        //metodo Buscar 
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Persona_S_Busqueda", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                sqlConnection.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

        }

        //metodo Verificar 
        public string Existe(string Valor)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Persona_Verificar", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
                SqlParameter PExiste = new SqlParameter();
                PExiste.ParameterName = "@pexiste";
                PExiste.SqlDbType = SqlDbType.Int;
                PExiste.Direction = ParameterDirection.Output;
                sqlConnection.Open();

                Rpta = Convert.ToString(PExiste.Value);


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }
        public string Insertar(Persona objPersona)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Persona_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
            
                comando.Parameters.Add("@ppersona_id", SqlDbType.Int).Value = objPersona.Persona_id;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objPersona.Nombre;
                comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = objPersona.Apellido;
                comando.Parameters.Add("@psexo", SqlDbType.Char).Value = objPersona.Sexo;
                comando.Parameters.Add("@pemail", SqlDbType.VarChar).Value = objPersona.Email;
                comando.Parameters.Add("@pcelular", SqlDbType.VarChar).Value = objPersona.Celular;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el registro...";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
        //Metodo actualizar
        public string Actualizar(Persona objPersona)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Persona_U", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ppersona_id", SqlDbType.Int).Value = objPersona.Persona_id;
                comando.Parameters.Add("@pDni", SqlDbType.VarChar).Value = objPersona.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objPersona.Nombre;
                comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = objPersona.Apellido;
                comando.Parameters.Add("@psexo", SqlDbType.Char).Value = objPersona.Sexo;
                comando.Parameters.Add("@pemail", SqlDbType.VarChar).Value = objPersona.Email;
                comando.Parameters.Add("@pcelular", SqlDbType.VarChar).Value = objPersona.Celular;
                comando.Parameters.Add("@pfechanacimiento", SqlDbType.VarChar).Value = objPersona.FechaNac;
                comando.Parameters.Add("@pfoto", SqlDbType.VarChar).Value = objPersona.foto;




                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro...";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
        //Metodo Eliminar
        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Persona_E", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ppersona_id", SqlDbType.Int).Value = Id;

                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro...";


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }

    }
}
