using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscritorio.Entidad
{
    public class Usuario
    {
        public int usuario_id{ get; set; }
        public int persona_id{ get; set; }
        public string usuario{ get; set; }
        public string clave{ get; set; }
        public string nivel{ get; set; }
        public string estado{ get; set; }
        public string nuevaclave{ get; set; }
    }
}
