using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EytanOOP
{
    internal class Reptile:Animals
    {
        protected double tailength;

        public Reptile(string name, int age, bool isup, int calories, double tailength)
            :base(name,age,isup,calories)
        {
            this.tailength = tailength;
        }

        public double GetTailength()
        {
            return this.tailength;
        }
        public void SetTailength(double tailength)
        {
            this.tailength=tailength;
        }
        public override string ToString()
        {
            return base.ToString() + $"{tailength}";
        }
    }
}
