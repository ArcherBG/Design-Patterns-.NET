using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RoundFactory : AbstractFactory
    {
        public override IShape getShape(string type)
        {
            if (type.Equals("square"))
            {
                return new RoundSquare();
            }
            else if (type.Equals("rectangle"))
            {
                return new RoundRectangle();
            }
            else
            {
                return null;
            }
        }
    }
}
