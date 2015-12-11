using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Pentagon : Shape
    {
        private double side;

        public Pentagon()
        {
            side = 0;
        }

        public Pentagon(double side)
        {
            this.side = side;
        }

        public void setSide(double side)
        {
            this.side = side;
        }

        public override double getArea()
        {
            return Math.Round(0.25 * Math.Sqrt(5 * (Math.Sqrt(5) * 2 + 5)) * Math.Pow(side, 2), 2);
        }
    }
}
