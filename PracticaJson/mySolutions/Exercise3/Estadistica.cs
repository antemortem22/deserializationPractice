using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Estadistica
    {
        [JsonPropertyName("equipo")]
        public string nombre { get; set; }
        public List<Jugador> jugadores { get; set; }
        public bool campeon { get; set; }

        public Estadistica()
        {
            jugadores = new List<Jugador>();
        }
    }
}
