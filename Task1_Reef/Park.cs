using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Park
    {
        protected Animal[] animals1;
        public Animal[] Animals1 { get { return animals1; } set { animals1 = value; } }
        protected int animalsnum;
        public int Animalsnum { get { return animalsnum; } set { animalsnum = value; } }
        public Park()
        {
            this.animals1 = new Animal[1000];
            this.animalsnum = 0;
        }
        public bool AddAnimal(Animal a)
        {
            int i = 0;
            foreach (Animal item in this.Animals1)
            {
                if(item == null)
                {
                    this.Animals1[i] = a;
                    return true;
                }
                i++;  
            }
            return false;
        }
        public List<Animal> Animallst()
        {
            List<Animal> lst = new List<Animal>();
            foreach (Animal item in this.Animals1)
            {
                if(item != null)
                {
                    if(item.Istal == true && item.Age > 10)
                    {
                        lst.Add(item);
                    }
                }
            }
            return lst;
        }
        public int SpecialReptiles()
        {
            int counter = 0;
            foreach (Animal item in this.animals1)
            {
                if(item is Reptile || item is Bird)
                {
                    if (item.Istal == true)
                        counter++;
                }
            }
            return counter;
        }
    }
}
