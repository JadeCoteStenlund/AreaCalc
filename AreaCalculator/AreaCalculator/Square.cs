using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Square : Shape
    {
        private double length;
        private double height;

        public Square()
        {
            length = 0;
            height = 0;
        }

        public Square(double length)
        {
            this.length = length;
            height = length;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public override double getArea()
        {
            return Math.Round(Math.Pow(length, 2), 2);
        }
    }
}
