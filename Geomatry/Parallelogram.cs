using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatry
{
    class Parallelogram : Square
    {

        float slope;
        float sideB;

        public float SideB { get { return sideB; } set { sideB = value; } }

        public Parallelogram(float a, float b, float v) : base(a)
        {
            sideB = b;
            slope = v;
        }

        public override float GetArea()
        {
            this.area = this.SideA * this.SideB * (float)Math.Sin(slope);
            return area;
        }
    }
}
