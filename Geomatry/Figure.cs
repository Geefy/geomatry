using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatry
{
    abstract class Figure
    {
        protected float circumference;
        protected float area;
        float sideA;
        public float SideA { get { return sideA; } set { sideA = value; } }

        public Figure(float a)
        {
            this.sideA = a;
        }

        public abstract float GetCircumference();

        public abstract float GetArea(); 

        public override string ToString()
        {
            return "This figures area is " + GetArea() + "\n and it's circumference is " + GetCircumference() + "\n";
        }

    }
}
