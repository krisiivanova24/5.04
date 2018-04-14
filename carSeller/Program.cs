using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<Engine> eng = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input1 = Console.ReadLine().Split().ToArray();
                Engine engine = new Engine(input1[0], n/i);
                if (input1.Length == 2)
                {
                     engine = new Engine(input1[0], int.Parse(input1[1]));
                } else
                if (input1.Length == 3)
                {
                    engine = new Engine(input1[0], int.Parse(input1[1]), int.Parse(input1[2]));
                    Console.WriteLine("YEEEEEE, Uspqqqq! Congratulations!");

                }else
                if (input1.Length == 3)
                {
                     engine = new Engine(input1[0], int.Parse(input1[1]), input1[2]);                    
                    
                }
                else               
                
                if (input1.Length == 4)
                {
                    engine = new Engine(input1[0], int.Parse(input1[1]), int.Parse(input1[2]), input1[3]);
                }
                eng.Add(engine);

            }
            byte m = byte.Parse(Console.ReadLine());
            List<string> cars = new List<string>();
            for (int i = 0; i < m; i++)
            {
                string aCar = Console.ReadLine();
            }
            for (int i = 0; i < m; i++)
            {
                List<string> one = cars[i].Split(' ').ToList();
            }
        }
    }
}
