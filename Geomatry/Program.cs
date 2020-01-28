using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Parallelogram(3, 4, 20));
            figures.Add(new Rectangle(4));
            figures.Add(new Trapez(5, 4, 3));
            figures.Add(new Triangle(2, 4, 3));

            foreach (Figure figure in figures)
            {
                Console.WriteLine(figure.ToString());
            }
            Console.Read();
        }
    }
}
