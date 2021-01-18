using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CineCartelera.Controllers
{
    public class Cine
    {
        public int Sala { get; set; }
        public DateTime Horario { get; set; }
        public string Clasificacion { get; set; }
    }
}