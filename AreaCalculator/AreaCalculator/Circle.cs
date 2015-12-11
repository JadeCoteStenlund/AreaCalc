using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : Shape  
    {
        private double radius;

        public Circle()
        {
            radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
    }
}
