using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSeller
{
    class Car
    {
        private string model;
        private string engine;
        private int weight;//
        private string colour;//
        

        public Car(string model, string engine)
        {
            this.model = model;
            this.engine = engine;
        }
        public Car(string model, string engine, int weight)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            
        }
        public Car(string model, string engine, string colour)
        {
            this.model = model;
            this.engine = engine;
            this.colour = colour;
        }
        public Car(string model, string engine, int weight, string colour)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.colour = colour;
            
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public string Colour
        {
            get { return this.colour; }
            set { this.colour= value; }
        }
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
    }
}
