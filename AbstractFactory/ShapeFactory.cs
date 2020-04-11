using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShapeFactory : AbstractFactory
    {
        public override IShape getShape(string type)
        {
            if (type.Equals("square"))
            {
                return new Square();
            }
            else if (type.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else
            {
                return null;
            }
        }
    }
}
