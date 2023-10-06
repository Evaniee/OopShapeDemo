﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapeDemo
{
    public class Triangle : Regular2DShape
    {
        public Triangle(double length) : base(length) { }

        public override double Area()
        {
            return (Math.Pow(_length, 2)) * (Math.Sqrt(3) / 4);
        }
    }
}