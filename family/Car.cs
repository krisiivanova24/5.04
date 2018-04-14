using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Car
    {
        private string model;
        private float engine;
        private float razhod;
        private float km=0;
        private List<Car> car = new List<Car>();

        public string Model {
            get { return this.model; }
            set { this.model = value; }
        }
        public float Engine {
            get { return this.engine; }
            set { this.engine = value; }
        }
        public float Razhod {
            get { return this.razhod; }
            set { this.razhod = value; }
        }
        public void Drive(string model, float km) {
            float po = this.Razhod * km;
            //Console.WriteLine(po);
            //Console.WriteLine(this.Engine);
            if (po < this.Engine)
            {
                this.Engine -= po;
                this.km += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public float Km {
            get { return this.km; }
            set { this.km = value; }
        }
        public List<Car> Cars
        {
            get { return this.car; }
            set { this.car = value; }
        }
        
    }
}
