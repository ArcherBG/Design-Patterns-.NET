using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryProducer
    {
        public AbstractFactory getFactory(Boolean isRound)
        {
            if (isRound)
            {
                return new RoundFactory();
            }else
            {
                return new ShapeFactory();
            }
        }
    }
}
