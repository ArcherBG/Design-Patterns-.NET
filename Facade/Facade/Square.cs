﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Square: Shape
    {
        public void Draw()
        {
            Console.WriteLine("In Square draw method");
        }
    }
}
