using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatry
{
    class Triangle : Figure
    {
        float sideB;
        float sideC;

        public float SideB { get { return sideB; } set { sideB = value; } }
        public float SideC { get { return sideC; } set { sideC = value; } }

        public Triangle(float a, float b, float c) : base(a)
        {
            sideB = b;
            sideC = c;
        }

        public override float GetArea()
        {
            area = 0.5f * SideA * SideB;

            return area;
        }

        public override float GetCircumference()
        {
            circumference = SideA + SideB + SideC;
            return circumference;
        }
    }
}
