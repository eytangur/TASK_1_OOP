﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EytanOOP
{
    internal class Bird:Animals
    {
        protected int flightHeight;
        protected int wingSize;

        public Bird(string name, int age, bool isup, int calories, int flightHeight, int WingSize)
            :base(name, age, isup, calories)
        {
            this.wingSize = WingSize;
            this.flightHeight = flightHeight;
        }

        public int GetFlightHeight()
        {
            return this.flightHeight;
        }
        public int GetWingSize()
        {
            return this.wingSize;
        }

        public void SetFlightHeight(int flightHeight)
        {
            this.flightHeight = flightHeight;
        }
        public void SetWingSize(int wingSize)
        {
            this.wingSize = wingSize;
        }
        public override string ToString()
        {
            return base.ToString() + $"{flightHeight}, {wingSize}";
        }

        public string Sing()
        {
            return "miao";
        }
        public void Dance()
        {
            Console.WriteLine("  \\_/");
            Console.WriteLine(".--_--.");
            Console.WriteLine("  \\_/");
        }
    }
}
