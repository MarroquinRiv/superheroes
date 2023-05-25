using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes.clases
{
    internal class superman : Isuperheroe
    {
        public string Nombre { get; set; }
        public int fuerza { get; set; }
        public int id { get; set; }
        public int agilidad { get; set; }

        public void volar()
        {
            Console.WriteLine("Superman vuela");
        }
        public void salvarElMundo()
        {
            Console.WriteLine("Superman salva el mundo");
        }
        public void presentarse()
        {
            Console.WriteLine("Hola, soy Superman");
        }
    }
}
