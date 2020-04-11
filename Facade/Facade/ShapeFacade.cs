using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class ShapeFacade
    {
        private Cirlce cirlce;
        private Square square;
        private Rectangle rectangle;

        public ShapeFacade()
        {
            this.cirlce = new Cirlce();
            this.square = new Square();
            this.rectangle = new Rectangle();
        }


        public void DrawCircle()
        {
            this.cirlce.Draw();
        }

        public void DrawSquare()
        {
            this.square.Draw();
        }

        public void DrawRectangle()
        {
            this.rectangle.Draw();
        }
    }
}
