using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num;
            do
            {
                Console.WriteLine("1. Периметър на квадрат ");
                Console.WriteLine("2. Лице на квадрат");
                Console.WriteLine("3. Периметър на правоъгълник");
                Console.WriteLine("4. Лице на правоъгълник");
                Console.WriteLine("5. Лице на кръг");
                Console.Write("Направи своя избор: ");
                num = byte.Parse(Console.ReadLine());

            } while (num < 1 || num > 5);

            //if ()
            //{
            //    Console.Write("Въведи коректни данни!: ");
            //    num = byte.Parse(Console.ReadLine());
            //}
            switch (num)
            {
                case 1:
                    {
                        Console.Write("Въведи страна на квадрата: ");
                        double a = byte.Parse(Console.ReadLine());
                        Console.Write("Резултат: ");
                        Console.WriteLine( Geometry.SquarePerimeter(a) ); 
                        
                        break;
                    }
                case 2: {
                        Console.Write("Въведи страна на квадрата: ");
                        double a = byte.Parse(Console.ReadLine());
                        Console.Write("Резултат: ");
                        Console.WriteLine( Geometry.SquareArea(a) ); 
                        break;
                    }
                case 3:
                    {
                        Console.Write("Въведи страни на правоъгълника: ");
                        double a = Byte.Parse(Console.ReadLine());
                        double b = Byte.Parse(Console.ReadLine());
                        Console.Write("Резултат: ");
                        Console.WriteLine(Geometry.RectanglePerimeter(a, b)  ); 
                        break;
                    }
                case 4:
                    {
                        Console.Write("Въведи страни на правоъгълника: ");
                        double a = Byte.Parse(Console.ReadLine());
                        double b = Byte.Parse(Console.ReadLine());
                        Console.Write("Резултат: ");
                        Console.WriteLine(Geometry.RectangleArea(a, b)  ); 
                        break;
                    }
                case 5:
                    {
                        Console.Write("Въведи радиуса на кръга: ");
                        double a = Byte.Parse(Console.ReadLine());
                        Console.Write("Резултат: ");
                        Console.WriteLine(Geometry.CircleArea(a)); 
                        break;
                    }

            }
        }
    }
}
