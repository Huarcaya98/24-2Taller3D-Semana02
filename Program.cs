using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3D_Semana02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figura;
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Ingrese la figura");
                Console.WriteLine("1: Rectangulo");
                Console.WriteLine("2: Triangulo");
                Console.WriteLine("3: Circulo");

                figura = Console.ReadLine();

                switch (figura)
                {
                    case "1":

                        Console.WriteLine("Ingrese la base del Rectangulo");
                        float baseRectangulo = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del rectangulo");
                        float alturaRectangulo = float.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                        Console.WriteLine("El area del rectangulo es:" + rectangulo.calcArea());
                        Console.WriteLine("El perimetro del rectangulo es:" + rectangulo.calcPerimetro());



                        break;

                    case "2":

                        Console.WriteLine("Ingrese la base del Triangulo");
                        float baseTriangulo = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del Triangulo");
                        float alturaTriangulo = float.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine("El area del Triangulo es:" + triangulo.calcArea());
                        ;

                        break;

                    case "3":
                        Console.WriteLine("Ingrese el radio del círculo:");
                        float radio = float.Parse(Console.ReadLine());
                        Circulo circulo = new Circulo(radio);
                        Console.WriteLine("El área del círculo es: " + circulo.calcArea());
                        break;


                    default:
                        Console.WriteLine("No existes esta operacion");
                        break;
                }


                Console.WriteLine("Continuar si o no");
                string option = Console.ReadLine();

                if (option == "no")
                {
                    continueFlag = false;
                }
            }
        }
    }
}
