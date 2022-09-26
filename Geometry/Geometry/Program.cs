using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Radius");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sideA");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sideB");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sideC");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height");
            int height = Convert.ToInt32(Console.ReadLine());


            Circle circle = new Circle(r);
            Triangle triangle = new Triangle(a,b,height, c);
            Quadrat quadrat = new Quadrat(a);
            Quader quader = new Quader(a);
            Pyramide pyramide = new Pyramide(a, height);

            List<string> geometries = new List<string>() {"Kreis","Dreieck","Quadrat","Quader","Pyramide"};
            int j = 0;

            List<double> areas = new List<double>();
            List<double> scope = new List<double>();

            areas.Add(circle.FlächenInhalt());
            scope.Add(circle.Umfang());

            areas.Add(triangle.FlächenInhalt());
            scope.Add(triangle.Umfang());

            areas.Add(quadrat.FlächenInhalt());
            scope.Add(quadrat.Umfang());

            areas.Add(quader.FlächenInhalt());
            scope.Add(quader.Umfang());

            areas.Add(pyramide.FlächenInhalt());
            scope.Add(pyramide.Umfang());



            for (int i = 0; i < areas.Count; i++)
            {
                Console.ReadKey();

                if (i == areas.Count)
                {
                    Console.WriteLine($"Der OberflächenInhalt von der {geometries[j]} ist {areas[i]}.");
                }

                else
                {
                    Console.WriteLine($"Der FlächenInhalt vom {geometries[j]} ist {areas[i]}.");
                    j++;
                }
            }

            j = 0;

            for (int i = 0; i < scope.Count; i++)
            {
                Console.ReadKey();
                if (i == areas.Count)
                {
                    Console.WriteLine($"Der Umfang von der {geometries[j]} ist {areas[i]}.");
                    j++;
                }
                else 
                {
                    Console.WriteLine($"Der Umfang vom {geometries[j]} ist {areas[i]}.");
                    j++;
                }

            }





            Console.ReadKey();
        }
    }
}
