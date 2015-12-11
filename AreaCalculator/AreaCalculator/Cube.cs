using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Cube : Shape
    {
        private double edge;

        public Cube()
        {
            edge = 0;
        }

        public Cube(double edge)
        {
            this.edge = edge;
        }

        public void setEdge(double edge)
        {
            this.edge = edge;
        }

        public override double getArea() // Volume
        {
            return Math.Round(Math.Pow(edge, 3), 2);
        }
    }
}
