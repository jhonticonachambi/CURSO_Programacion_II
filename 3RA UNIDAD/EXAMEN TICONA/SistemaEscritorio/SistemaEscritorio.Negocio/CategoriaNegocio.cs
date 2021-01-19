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
    public class CategoriaNegocio
    {
        //Metodo Listar
        public static DataTable Listar()
        {
            CategoriaDatos objCategoria = new CategoriaDatos();
            return objCategoria.Listar();
        }
        // Metodo Buscar
        public static DataTable Buscar(string Busqueda  )
        {
            CategoriaDatos objCategoria = new CategoriaDatos();
            return objCategoria.Buscar(Busqueda);
        }
        //Metodo Insertar
        public static string Insertar(string Nombre, string Descripcion, string Estado)
        {
            CategoriaDatos objCategoria = new CategoriaDatos();

            string Existe = objCategoria.Existe(Nombre);
            if(Existe.Equals("1"))
            {
                return "La categoria ya existe en la base de datos...";
            }
            else
            {
                Categoria objCategoriaE = new Categoria();
                objCategoriaE.Nombre = Nombre;
                objCategoriaE.Descripcion = Descripcion;
                objCategoriaE.Estado = Estado;
                return objCategoria.Insertar(objCategoriaE);
            }
           
        }















        //Metodo Actualizar
        public static string Actualizar(int Id, string NombreAnterior, string Nombre, string Descripcion, string Estado)
        {

            CategoriaDatos objCategoria = new CategoriaDatos();
            Categoria obj = new Categoria();//Capa entidad

            if (NombreAnterior.Equals(Nombre))
            {
                obj.CategoriaId = Id;
                obj.Nombre = Nombre;
                obj.Descripcion = Descripcion;
                obj.Estado = Estado;
                return objCategoria.Actualizar(obj);

            }
            else
            {
                string Existe = objCategoria.Existe(Nombre);
                if (Existe.Equals("1"))
                {

                    return "La categoria ya existe en la base de datos...";

                }
                else
                {

                    Categoria objCategoriaE = new Categoria();
                    objCategoriaE.CategoriaId = Id;
                    objCategoriaE.Nombre = Nombre;
                    objCategoriaE.Descripcion = Descripcion;
                    objCategoriaE.Estado = Estado;
                    return objCategoria.Actualizar(objCategoriaE);

                }

            }
           

        }
        //Metodo Eliminar
        public static string Eliminar(int Id)
        {
            CategoriaDatos objCategoria = new CategoriaDatos();

            return objCategoria.Eliminar(Id);
           
        }
        //Metodo Activar
        public static string Activar(int Id)
        {
            CategoriaDatos objCategoria = new CategoriaDatos();

            return objCategoria.Activar(Id);

        }
        public static string Desactivar(int Id)
        {
            CategoriaDatos objCategoria = new CategoriaDatos();

            return objCategoria.Desactivar(Id);
        }


    }
}
