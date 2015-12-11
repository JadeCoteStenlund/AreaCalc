using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Octagon : Shape
    {
        private double side;

        public Octagon()
        {
            side = 0;
        }

        public Octagon(double side)
        {
            this.side = side;
        }

        public void setSide(double side)
        {
            this.side = side;
        }

        public override double getArea()
        {
            return Math.Round(2 * (Math.Sqrt(2) + 1) * Math.Pow(side, 2), 2);
        }
    }
}
