using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatry
{
    class Square : Figure
    {

        public Square(float a) : base(a)
        {
            
        }


        public override float GetCircumference()
        {
            circumference = SideA * 4;
            

            return circumference;
        }

        public override float GetArea()
        {
            area = SideA * SideA;
            return area;
        }
    }
}
