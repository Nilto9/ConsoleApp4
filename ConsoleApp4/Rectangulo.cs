using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Rectangulo
    {
        public Punto p1 { get; set; }
        public Punto p2 { get; set; }
        public Punto p3 { get; set; }
        public Punto p4 { get; set; }

        public int CalcularArea()
        {
            int Area = (p3.y - p1.y) * (p2.x - p1.x);
            return (Area);
        }
        public int CalcularPerimetro()
        {
            int peri = Math.Abs(((p3.y + p1.y) * 2) + ((p2.x + p1.x) * 2));
            return peri;
        }
    }
}
