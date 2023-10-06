using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapeDemo
{
    public class Square : Regular2DShape
    {
        public Square(double length) : base(length)
        {
        }

        public override double Area()
        {
            return Math.Pow(_length, 2);
        }
    }
}
