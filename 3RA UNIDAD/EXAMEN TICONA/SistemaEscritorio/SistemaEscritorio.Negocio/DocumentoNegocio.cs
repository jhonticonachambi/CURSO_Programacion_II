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
    public class DocumentoNegocio
    {
        public static DataTable Listar()
        {
            DocumentoDatos objDocumento = new DocumentoDatos();
            return objDocumento.Listar();
        }
    
        public static string Eliminar(int Id)
        {
            DocumentoDatos objDocumento = new DocumentoDatos();

            return objDocumento.Eliminar(Id);

        }
        public static DataTable Buscar(string Busqueda)
        {
            DocumentoDatos objDocumento = new DocumentoDatos();
            return objDocumento.Buscar(Busqueda);
        }




        public static string Insertar(string categoriaa,string nombre,string extension,string tamaño,string descripcion,string estado)
    {
        DocumentoDatos objDocumento = new DocumentoDatos();

        string Existe = objDocumento.Existe(categoriaa);

        if (Existe.Equals("1"))
        {
            return "La categoria ya existe en la base de datos...";
        }
        else
        {
            Documento objDocumnetoE = new Documento();

            objDocumnetoE.categoria = categoriaa;
            objDocumnetoE.nombre = nombre;
            objDocumnetoE.extension = extension;
            objDocumnetoE.tamaño = tamaño;
            objDocumnetoE.descripcion = descripcion;
            objDocumnetoE.estado = estado;

            return objDocumento.Insertar(objDocumnetoE);
        }

    }
    }

}
