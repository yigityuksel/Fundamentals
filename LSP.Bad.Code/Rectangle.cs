﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Bad.Code
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public virtual int CalculateArea()
        {
            return Height * Width;
        }

    }
}
