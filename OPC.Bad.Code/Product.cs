﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC.Bad.Code
{
    public class Product
    {

        public string Name { get; set; }

        public Size Size { get; set; }

        public Color Color { get; set; }
        
        public Product(string name, Size size, Color color)
        {
            Name = name;
            Size = size;
            Color = color;
        }

        public override string ToString()
        {
            return $" - {Name} - {Size} - {Color} ";
        }
    }

    public enum Size
    {
        Small, Medium, Large, Enormus
    }

    public enum Color
    {
        Red, Green, Blue, Yellow
    }

}
