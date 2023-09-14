using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EytanOOP
{
    internal class Snake:Reptile
    {
        protected bool venomous;
        private int speed;

        public Snake(string name, int age, bool isup, int calories, double tailength, int v, bool venomous)
            : base(name, age, isup, calories, tailength)
        {
            this.venomous = venomous;
        }

        public Snake(string name, int age, bool isup, int calories, double tailength, bool venomous, int speed) : base(name, age, isup, calories, tailength)
        {
            this.venomous = venomous;
            this.speed = speed;
        }

        public bool GetVenomous()
        {
            return this.venomous;
        }
        public void SetVenomous(bool venomous)
        {
            this.venomous = venomous;
        }
        public override string ToString()
        {
            return base.ToString() + $"{venomous}";
        }
        public string Dance()
        {
            return "if you're a snake then tear it up on the floor";
        }
    }
}
