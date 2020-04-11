using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    public class RedDecoratedShape: CirlceDecorator
    {

        public RedDecoratedShape(IShape decoratedShape): base(decoratedShape)
        {         
        }

        public void SetRedBoder()
        {
            Console.WriteLine("Set red border");
        }

        public override void Draw()
        {
            base.Draw();
            this.SetRedBoder();
        }

    }
}
