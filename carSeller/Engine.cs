using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSeller
{
    class Engine
    {
        private string model;
        private int power;
        private int kubatura;//
        private string effi;//
        private List<Engine> eng = new List<Engine>();

        public Engine(string model, int power) {
            this.model = model;
            this.power = power;
            
            
        }
        public Engine(string model, int power, int kubatura)
        {
            this.model = model;
            this.power = power;
            this.kubatura = kubatura;
            Console.WriteLine("YEEEEEE, Uspqqqq! Congratulations!");
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
    }
}
