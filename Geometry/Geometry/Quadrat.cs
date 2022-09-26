using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Quadrat : Geometry
    {
        public Quadrat(int sideA)
        {
            SideA = sideA;
        }
        public override double FlächenInhalt()
        {
            return SideA * SideA;
        }
        public override double Umfang()
        {
            return SideA * 4;
        }
    }
}
