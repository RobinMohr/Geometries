using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Geometry
    {
        public int Radius   { get; set; }
        public int SideA    { get; set; }
        public int SideB    { get; set; }
        public int Height   { get; set; }
        public int SideC    { get; set; }   

        public abstract double FlächenInhalt();

        public abstract double Umfang();

    }
}
