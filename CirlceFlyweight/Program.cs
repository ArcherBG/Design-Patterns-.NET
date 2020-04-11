using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirlceFlyweight
{
    class Program
    {
        private static string[] colors = new string[] {"Red", "Green", "Blue", "White", "Black"};
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Cirlce circle = (Cirlce)ShapeFactory.GetCirlce(getRandomColor());
                circle.x = i*i;
                circle.y = i+i;
                circle.radius = 10;
                circle.Draw();
            }
        }

        private static String getRandomColor()
        {
            return colors[(int)(new Random().Next() * colors.Length)];
        }
    }
}
