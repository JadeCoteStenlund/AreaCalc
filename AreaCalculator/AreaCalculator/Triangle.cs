using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Triangle : Shape
    {
        private double _base;
        private double height;
        private double side;
        private double angle;

        public Triangle()
        {
            height = 0;
            _base = 0;
        }

        public Triangle(double _base, double side, double angle)
        {
            this._base = _base;
            this.side = side;
            this.angle = angle;
        }

        public Triangle(double _base, double height)
        {
            this._base = _base;
            this.height = height;
        }

        public void setBase(double _base)
        {
            this._base = _base;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public void setSide(double side)
        {
            this.side = side;
        }

        public void setAngle(double angle)
        {
            this.angle = angle;
        }

        public override double getArea()
        {
            return Math.Round(_base * height * 0.5, 2);
        }

        public double getAreaWithAngle()
        {
            return Math.Round(Math.Sin(Math.PI * angle / 180) / 2 * _base * side, 2);
        }
    }
}
