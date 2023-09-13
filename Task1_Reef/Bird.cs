using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Bird : Animal , IBird
    {
        protected int wingslength { get; set; }
        protected int flhight { get; set; }
        public Bird(string name, int age, bool istal, double cals, int flhight, int wingslength) : base(name, age, istal, cals)

        {
            this.flhight = flhight;
            this.wingslength = wingslength;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nwinglength:{wingslength}\nflhight:{flhight}";
        }
        public string Sing()
        {
            return  "🦃🐔🐤🐥🦆🦅🕊️🐧: " + "🎤🧑🏾‍🎤👨🏾‍🎤👩🏾‍🎤👩🏾‍🎤";
        }
        public string Dance()
        {
            return "🐓🐣🐤🐥: " + "💃💃🕺🪩👯👯‍♂️👯‍♀️💃💃💃🏾💃🏾💃🏾";
        }

        public bool Takeoff(object o)
        {
            return o==null;
        }

        public bool Landing(object o)
        {
            return o == null;
        }

        public bool Soaring(object o)
        {
            return o == null;
        }
    }
}
