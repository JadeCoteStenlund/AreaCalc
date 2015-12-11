using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Hexagon : Shape
    {
        private double side;

        public Hexagon()
        {
            side = 0;
        }

        public Hexagon(double side)
        {
            this.side = side;
        }

        public void setSide(double side)
        {
            this.side = side;
        }

        public override double getArea()
        {
            return Math.Round(3 * Math.Sqrt(3) / 2 * Math.Pow(side, 2), 2);
        }
    }
}
