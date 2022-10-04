﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public class Rectangle : Shape2D
    {
        public Rectangle(int width, int height) : base("Prostokąt", width, height)
        {
        }
    }

    public class Square : Rectangle
    {
        public Square(int size) : base(size, size)
        {
        }
    }
}
