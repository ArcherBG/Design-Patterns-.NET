using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDemo
{
    public class Cricket : Game
    {
        public override void EndGame()
        {
            Console.WriteLine("Cricket game ended");
        }

        public override void Initialize()
        {
            Console.WriteLine("Cricket game ininted");
        }

        public override void StartGame()
        {
            Console.WriteLine("Cricket game started");
        }
    }
}
