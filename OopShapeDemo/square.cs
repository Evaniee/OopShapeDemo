using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapeDemo
{
    public class square : Regular2DShape
    {
        public square(double length) : base(length)
        {
        }

        public override double Area()
        {
            return (Length * Length);
        }
    }
}
