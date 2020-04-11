using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    public abstract class CirlceDecorator: IShape
    {
        private IShape decoratedShape;

        public CirlceDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public void Draw()
        {
            this.decoratedShape.Draw();
        }
    }
}
