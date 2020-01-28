using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatry
{
    class Trapez : Square
    {
        float height;
        float sideB;
        float sideC;
        float sideD;

        public float SideB { get { return sideB; } set { sideB = value; } }
        public float SideC { get { return sideC; } set { sideC = value; } }
        public float SideD { get { return sideD; } set { sideD = value; } }

        public Trapez(float a, float b, float c) : base(a)
        {
            sideB = b;
            sideC = c;
            sideD = b;
        }

        public override float GetArea()
        {
           area = 0.50f * (SideA + SideC) * GetHeight();
            return area;
        }

        private float GetHeight()
        {
            float s = (SideA + SideB - SideC + SideD) / 2;
            height = (2 / (SideA - SideC)) * ((float)Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD)));
             return height;
        }
    }
}
