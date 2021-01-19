using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscritorio.Entidad
{
    public class Documento
    {
        public int documento_id { get; set; }
        public string categoria { get; set; }
        public string nombre { get; set; }
        public string extension { get; set; }
        public string tamaño { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
