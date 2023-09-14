using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EytanOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "eytan", "or", "liam", "lior","riff","jacob","maya","noa"};
            Random rnd = new Random();            


            Animals[] animals = new Animals[]
            {
                new Animals(names[rnd.Next(1,8)], rnd.Next(1,120), false, rnd.Next(500,50000)),
                new Reptile(names[rnd.Next(1,8)], rnd.Next(1,120), false, rnd.Next(500,50000), rnd.Next(500, 50000)),
                new Cow(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,rnd.Next(0,10)),
                new Hipo(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,rnd.Next(20,50)),
                new Hipo(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,rnd.Next(20,50)),
                new Hipo(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,rnd.Next(20,50)),
                new Cow(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,rnd.Next(0,10)),
                new Animals(names[rnd.Next(1,8)], rnd.Next(1,120), false, rnd.Next(500,50000)),


            };
            foreach (Animals item1 in animals)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("---------------------------");
            Reptile[] arrReptile = new Reptile[]
            {
                 new Snake (names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,true),
                 new Snake (names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,false),
                 new Cobra (names[rnd.Next(1, 8)], rnd.Next(1, 120), true, rnd.Next(500, 50000), rnd.Next(500, 50000), true, rnd.Next(10, 100)),
                 new Cobra (names[rnd.Next(1, 8)], rnd.Next(1, 120), true, rnd.Next(500, 50000), rnd.Next(500, 50000), true, rnd.Next(10, 100)),
                 new Crocodile (names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),12,false),
            };

            foreach (var item2 in arrReptile)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("---------------------------");
            Mammal[] arrMammal = new Mammal[]
            {
                new Mammal(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),rnd.Next(1,12)),
                new Mammal(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),rnd.Next(1,12)),
                new Mammal(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),rnd.Next(1, 12)),
                new Mammal(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),rnd.Next(1, 12)),
                new Mammal(names[rnd.Next(1,8)], rnd.Next(1,120), true, rnd.Next(500,50000),rnd.Next(500,50000),rnd.Next(1, 12)),
            };

            foreach (var item3 in arrMammal)
            {
                Console.WriteLine(item3);
            }
        }
    }
}

