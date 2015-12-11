using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class RectangularPrism : Shape
    {
        private double length;
        private double height;
        private double width;

        public RectangularPrism()
        {
            length = 0;
            height = 0;
            width = 0;
        }

        public RectangularPrism(double length, double height, double width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public override double getArea()
        {
            return Math.Round(length * height * width, 2);
        }
    }
}
