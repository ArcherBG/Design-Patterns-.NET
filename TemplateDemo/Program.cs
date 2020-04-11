using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game footballGame = new Football();
            footballGame.Play();

            Game cricketGame = new Cricket();
            cricketGame.Play();

            Console.ReadKey();
        }
    }
}
