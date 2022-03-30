using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{ 
    public class Punto
    {
        public int x { get; set; }
        public int y { get; set; }
        public Punto(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
    }
}
