using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Quader : Geometry
    {
        public Quader(int sideA)
        {
            SideA = sideA;
        }
        public override double FlächenInhalt()
        {
            return SideA * SideA * 6;
        }
        public override double Umfang()
        {
            return SideA * 12;
        }
    }
}
