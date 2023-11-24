using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Usuario
    {
        public string usuario { get; set; }
        public List<string> amigos_usuario { get; set; }
        public bool notificaciones_usuario { get; set; }
    }
}
