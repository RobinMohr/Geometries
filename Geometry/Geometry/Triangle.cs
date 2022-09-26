using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Geometry
    {
        public Triangle(int sideA, int sideB, int height, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = height;
        }
        public override double FlächenInhalt()
        {
            return SideA * Height / 2 ;
        }
        public override double Umfang()
        {
            return SideA + SideB + SideC;
        }
    }
}
