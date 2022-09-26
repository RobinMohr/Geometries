using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Pyramide : Geometry
    {
        public Pyramide(int sideA, int height)
        {
            SideA = sideA;
            Height = height;
        }
        public double Volumen()
        {
            return SideA * Height / 3 ;
        }
        public override double FlächenInhalt()
        {
            return SideA * Height * 2 + SideA * SideA;
        }
        public override double Umfang()
        {
            return SideA * 4 + (Height * Height + SideA * SideA) * 4;
        }
    }
}
