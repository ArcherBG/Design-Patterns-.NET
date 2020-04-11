using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder standardMazeBuilder = new StandardMazeBuilder();
            IBuilder difficultMazeBuilder = new DifficultMazeBuilder();

            DirectorBuilder directorBuilder = new DirectorBuilder();

            directorBuilder.Construct(standardMazeBuilder);
            standardMazeBuilder.GetMaze().Show();

            directorBuilder.Construct(difficultMazeBuilder);
            difficultMazeBuilder.GetMaze().Show();

            Console.ReadKey();
        }
    }
}
