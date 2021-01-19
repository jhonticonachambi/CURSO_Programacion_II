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
    public class PersonaNegocio
    {
        //Metodo Listar
        public static DataTable Listar()
        {
            PersonaDatos objPersona = new PersonaDatos();
            return objPersona.Listar();
        }
        // Metodo Buscar
        public static DataTable Buscar(string Busqueda)
        {
            PersonaDatos objPersona = new PersonaDatos();
            return objPersona.Buscar(Busqueda);
        }
        //Metodo Insertar
        public static string Insertar(string Nombre, string Apellido, string Dni, string Celular, string Email, string Direccion, string Sexo, string FechaNac)
        {
            PersonaDatos objPersona = new PersonaDatos();

            string Existe = objPersona.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe en la base de datos...";
            }
            else
            {
               Persona objPersonaE = new Persona();
                objPersonaE.Dni = Dni;
                objPersonaE.Nombre = Nombre;
                objPersonaE.Apellido = Apellido;
                objPersonaE.Email = Email;
                objPersonaE.Celular = Celular;
                objPersonaE.Direccion = Direccion;
                objPersonaE.FechaNac = FechaNac;

                return objPersona.Insertar(objPersonaE);
            }

        }
        //Metodo Actualizar
        public static string Actualizar(int personaid, string Dni, string Nombre, string Apellido, string sexo, string Email, string Celular, string Direccion, string Fechanac)
        {

            PersonaDatos objPersona = new PersonaDatos();

            string Exist = objPersona.Existe(Nombre);
            if (Exist.Equals("1"))
            {
                return "La Persona ya Existe en la Base Datos...";
            }
            else
            {
                Persona objPersonaE = new Persona();
                objPersonaE.Persona_id = personaid;
                objPersonaE.Dni = Dni;
                objPersonaE.Nombre = Nombre;
                objPersonaE.Apellido = Apellido;
                objPersonaE.Sexo = sexo;
                objPersonaE.Email = Email;
                objPersonaE.Celular = Celular;
                objPersonaE.Direccion = Direccion;
                objPersonaE.FechaNac = Fechanac;
                return objPersona.Actualizar(objPersonaE);
            }
        }


        
        //Metodo Eliminar
        public static string Eliminar(int Id)
        {
            PersonaDatos objPersona = new PersonaDatos();

            return objPersona.Eliminar(Id);

        }
       
      

    }
}
