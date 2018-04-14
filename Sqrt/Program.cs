using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<byte> all = new List<byte>();
            for (int i = 0; i < n; i++)
            {
                byte number = byte.Parse(Console.ReadLine());
                all.Add(number);
            }
            for (int i = 0; i < n; i++)
            {
                Sqrt nums = new Sqrt(all[i]);
                nums.Koren(all[i]);
            }
        }
    }
}
