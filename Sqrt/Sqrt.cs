using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
     class Sqrt
    {
        
        private byte num;

        public Sqrt(byte num) {
            this.num = num;
        }
        public byte Num {
            get { return this.num; }
            set { this.num = value; }
        }
        public void Koren(byte num){
            double fin = Math.Round(Math.Sqrt(num), 14);
            Console.WriteLine($"{fin}");

        }

    }
}
