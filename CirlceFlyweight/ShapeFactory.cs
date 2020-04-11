using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirlceFlyweight
{
    public class ShapeFactory
    {
        static private Dictionary<string, IShape> dictionary = new Dictionary<string, IShape>();

        public static IShape GetCirlce(string color)
        {
            IShape shape = null;
            bool isExist = dictionary.TryGetValue(color,  out shape );

            if (!isExist)
            {
                Cirlce circle = new Cirlce(color);
                dictionary.Add(color, (IShape)circle);
                Console.WriteLine("Create cirle with color: " + color);
            }

            return (Cirlce)shape;
        }
    }
}
