using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Mammal[] arrMammal = new Mammal[5];
            arrMammal[0] = new Mammal(name: "nadav", age: 44, istal: false, cals: 4000, milkcal: 4590, prtime: 10);
            arrMammal[1] = new Mammal(name: "lior", age: 30, istal: false, cals: 4200, milkcal: 4000, prtime: 10);
            arrMammal[2] = new Mammal(name: "shaul", age: 20, istal: false, cals: 4500, milkcal: 4500, prtime: 10);
            arrMammal[3] = new Hipo(name: "dror", age: 25, istal: false, cals: 3500, milkcal: 3980, prtime: 10,fatpricent:40.4);
            arrMammal[4] = new Cow(name: "david", age: 41, istal: false, cals: 2200,milkcal: 4321,prtime:12,hamlatotnum:4);
            Reptile[] arrReptile = new Reptile[5];
            arrReptile[0] = new Snake(name: "shon", age: 25, istal: false, cals: 1900, tailength: 5,isarsi:true);
            arrReptile[0] = new Python(name: "pipi", age: 25, istal: false, cals: 3900, tailength: 5, isarsi: true,bcolor: Colors.blue,teethsize:5);
            arrReptile[0] = new Reptile(name: "gg", age: 25, istal: false, cals: 2022, tailength: 5);
            arrReptile[0] = new Reptile(name: "shmulik", age: 25, istal: false, cals: 2000, tailength: 5);
            arrReptile[0] = new Reptile(name: "dvir", age: 25, istal: false, cals: 7639, tailength: 5);
            arrReptile[0] = new Reptile(name: "saba", age: 25, istal: false, cals: 4576, tailength: 5);

            Animal[] arranimals = new Animal[8];
            arranimals[0] = new Dror(name: "adam", age: 22, istal: false, cals: 3998,makorcolor:Colors.red,bodycolor:Colors.blue,flhight:56,wingslength:20);
            arranimals[1] = new Mammal(name: "aden", age: 24, istal: true, cals: 5600, milkcal: 3500, prtime: 12);
            arranimals[2] = new Reptile(name: "shon", age: 25, istal: false, cals: 3900,tailength:5);
            arranimals[3] = new Snake(name: "sharon", age: 30, istal: false, cals: 3804,tailength:2,isarsi:true);
            arranimals[4] = new Animal(name: "laflaf", age: 22, istal: true, cals: 4709);
            
            Console.WriteLine("Mammals: ");
            foreach (Mammal item in arrMammal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reptiles: ");
            foreach (Reptile item in arrReptile)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Animals: ");
            foreach(Animal item in arranimals)
            {
                Console.WriteLine(item);
            }

        }
        public static double TotalCals(Animal[] animals)
        {
            double total = 0;
            foreach (Animal item in animals)
            {
                total += item.Eat();
            }
            return total;
        }
        public static int MammalsCount(Animal[] animals)
        {
            int count = 0;
            foreach (Animal item in animals)
            {
                if(item is Mammal)
                {
                    count++;
                }
            }
            return count;
        }
        public static void StartDance(Animal[] animals)
        {
            foreach (Animal item in animals)
            {
                if (item is Snake)
                {
                    ((Snake)item).Dance();

                }
                else if(item is Bird)
                {
                    ((Bird)(item)).Dance();
                }
            }
        }
        public static string FatestHIpo(Animal[] animals)
        {
            double max = 0;
            string name = "NO Hipos";
            foreach (Animal item in animals)
            {
                if (item is Hipo)
                {
                    if(((Hipo)(item)).Fatpricent > max)
                    {
                        max = ((Hipo)(item)).Fatpricent;
                        name = ((Hipo)(item)).Name;
                    }
                }
                
            }
            return name;
        }
       

    }
}
