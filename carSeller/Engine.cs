using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSeller
{
    public class Engine // NEDOVYRSHENA
    {
        private string model;
        private int power;
        private int kubatura;//
        private string effi;//
        private string color;//
        private Car carOt;
        private List<Engine> eng = new List<Engine>();
        private int weight;
        private string en;

        public Engine(string model)
        {
            this.model = model;            

        }
        public Engine(string model, int power) {
            this.model = model;
            this.power = power;           
            
        }
        public Engine(string model, int power, int kubatura)
        {
            this.model = model;
            this.power = power;
            this.kubatura = kubatura;
           
        }
        public Engine(string model, int power, string effi)
        {
            this.model = model;
            this.power = power;
            this.effi = effi;
            
        }
        public Engine(string model, int power, int kubatura, string effi)
        {
            this.model = model;
            this.power = power;
            this.kubatura = kubatura;
            this.effi = effi;
        }
        public List<Engine> Eng {
            get { return this.eng; }
            set { this.eng = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
        public int Kubarura 
        {
            get { return this.kubatura ; }
            set { this.kubatura = value; }
        }
        public string Effi
        {
            get { return this.effi; }
            set { this.effi = value; }
        }
        public Car CarOt {
            get { return this.carOt; }
            set { this.carOt = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public string En
        {
            get { return this.en; }
            set { this.en = value; }
        }
    }
}
