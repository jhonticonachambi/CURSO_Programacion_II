using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscritorio.Datos;
using SistemaEscritorio.Entidad;
using System.Data;

namespace SistemaEscritorio.Negocio
{
    public class UsuarioNegocio
    {
        //Metodo loguear 
        public static DataTable Loguear(string Usuario, string Password)
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            return objUsuario.Loguear(Usuario, Password);
        }
        /*
        public static DataTable ActualizarContraseña(string Password)
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            return objUsuario.ActualizarContraseña (Password);
        }*/

        public static string ActualizarContraseña(string Password,string nuevaclaves)
        {

            UsuarioDatos objUsuario = new UsuarioDatos();

            string Exist = objUsuario.ExisteContraseña(Password);
            if (Exist.Equals("1"))
            {
                /*Usuario objUsuarioA = new Usuario();
                objUsuarioA.clave = Password;
                objUsuarioA.nuevaclave = nuevaclaves;
                return objUsuario.ActualizarContraseña();*/

                return "La Persona ya Existe en la Base Datos...";
            }
            else
            {
                Usuario objUsuarioA = new Usuario();
                objUsuarioA.clave = Password;
                objUsuarioA.nuevaclave = nuevaclaves;
                return objUsuario.ActualizarContraseña(objUsuarioA);
            }
        }






    }
}
