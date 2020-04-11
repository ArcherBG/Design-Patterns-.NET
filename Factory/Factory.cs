using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Factory
    {

        public IShape getShape(string shape)
        {
            if (shape.Equals("circle"))
            {
                return new Circle();
            } else if (shape.Equals("square"))
            {
                return new Square();
            }
            return null;
        }
    }
}
