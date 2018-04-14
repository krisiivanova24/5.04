using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string[] inputs = new string[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                inputs[i] = input;
            }
            List<string> com = new List<string>();
            string comm = Console.ReadLine();
            while (comm != "End")
            {
                com.Add(comm);
                comm = Console.ReadLine();
            }
            Array.Sort(inputs);
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] split = inputs[i].Split().ToArray();
                Car car = new Car();
                car.Model = split[0];
                car.Engine = float.Parse(split[1]);
                car.Razhod = float.Parse(split[2]);
                for (int t = 0; t < com.Count; t++)
                {
                    List<string> splitCom = com[t].Split().ToList();
                    if (String.Equals(split[0], splitCom[1] ))
                    {
                        car.Drive(split[0], float.Parse(splitCom[2]));
                        
                    }

                }
                cars.Add(car);

            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.Engine:f2} {item.Km}");
            }
        }
    }
}
