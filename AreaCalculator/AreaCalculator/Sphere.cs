using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Sphere : Shape
    {
        private double radius;

        public Sphere()
        {
            radius = 0;
        }

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public override double getArea() // Volume
        {
            return Math.Round(Math.PI * Math.Pow(radius, 3) * 1.33333, 2);
        }
    }
}
