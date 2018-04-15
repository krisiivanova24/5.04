using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSeller
{
    class Program// NEDOVYRSHENA
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<Engine> eng = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input1 = Console.ReadLine().Split().ToArray();
                Engine engine = new Engine(input1[0]);
                if (input1.Length == 2)
                {
                    engine = new Engine(input1[0], int.Parse(input1[1]));
                }
                else
                if (input1.Length == 3)
                {
                    engine = new Engine(input1[0], int.Parse(input1[1]), int.Parse(input1[2]));     
                }else
                if (input1.Length == 3)
                {
                     engine = new Engine(input1[0], int.Parse(input1[1]), input1[2]);  
                }
                else  
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
                cars.Add(aCar);
            }
            Dictionary<string, Engine> dicOfCars = new Dictionary<string, Engine>();
            for (int i = 0; i < m; i++)
            {
                List<string> one = cars[i].Split(' ').ToList();
                
                if (!dicOfCars.ContainsKey(one[0]))
                {
                    Engine oneT = new Engine(one[1]);
                    if (one.Count == 2)
                    {
                        dicOfCars[one[0]] = oneT;
                    }else
                        if (one.Count == 3)
                    {
                        oneT.CarOt.Color = one[2];
                        dicOfCars[one[0]] = oneT;
                    }
                    else
                        
                    {
                        oneT.Color = one[3];
                        oneT.En = one[1];
                        //oneT.Weight = Convert.ToInt32(one[2]);
                        
                        dicOfCars[one[0]] = oneT;
                    }


                }

            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(4);
                for (int j = 0; j < eng.Count; j++)
                {
                    Console.WriteLine(5);
                    if (dicOfCars.ContainsValue(eng[j]))
                    {
                        Console.WriteLine(6);
                        foreach (var item in dicOfCars)
                        {
                            Console.WriteLine(item.Key + ":");
                            Console.WriteLine(item.Value.Eng+":");
                            Console.Write("Power: ");
                            Console.WriteLine(item.Value.Power);
                            Console.Write("Dicplacement: ");
                            Console.WriteLine(item.Value.Kubarura);
                            Console.Write("Effi: ");
                            Console.WriteLine(item.Value.Effi);
                            Console.Write("Weight: ");
                            Console.WriteLine(item.Value.CarOt.Weight);
                            Console.Write("Color: ");
                            Console.WriteLine(item.Value.CarOt.Color);
                        }
                    }
                }
            }
            
        }
    }
}
