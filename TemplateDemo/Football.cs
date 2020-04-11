using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDemo
{
    public class Football : Game
    {
        public override void EndGame()
        {
            Console.WriteLine("Football game ended");
        }

        public override void Initialize()
        {
            Console.WriteLine("Football game initiated");
        }

        public override void StartGame()
        {
            Console.WriteLine("Football game started");
        }
    }
}
