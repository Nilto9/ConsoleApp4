using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese coordenadas :");
            Rectangulo rectangulo = new Rectangulo();
            //leer coordenadas

            

            Console.WriteLine("Ingrese valor de los primer punto ");
            int y1 = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            rectangulo.p1 = new Punto(x1, y1);

            Console.WriteLine("Ingrese valor de los segundo punto");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            rectangulo.p3 = new Punto(x2, y2);

            Console.WriteLine("Ingrese valor de los tercer punto");
            int y3 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            rectangulo.p3 = new Punto(x3, y3);

            Console.WriteLine("Ingrese valor de los cuarto punto");
            int y4 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            rectangulo.p4 = new Punto(x4, y4);


            double area = rectangulo.CalcularArea();
            double perimmetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El area del rectangulo es: " + area);
            Console.WriteLine("El perimetro del rectangulo es: " + perimmetro);

            Console.Read();
                
        }  

    }
}
