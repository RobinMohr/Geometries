using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Geometry
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double FlächenInhalt()
        {
            return Math.PI * Radius * Radius;
        }
        public override double Umfang()
        {
            return Radius * 2 * Math.PI;
        }
    }
}
