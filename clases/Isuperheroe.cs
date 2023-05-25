using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes.clases
{
    internal interface Isuperheroe
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int fuerza { get; set; }
        public int agilidad { get; set; }

        public void volar();
        public void salvarElMundo();
        public void presentarse();
    }
}
