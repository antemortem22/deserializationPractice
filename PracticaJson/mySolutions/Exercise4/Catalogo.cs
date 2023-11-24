using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Catalogo
    {
        public List<Productos> productos { get; set; }
        public Catalogo() 
        {
            productos = new List<Productos>();
        
        }
    }
}
