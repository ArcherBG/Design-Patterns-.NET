using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    class StandardMazeBuilder : IBuilder
    {
        private Maze maze;

        public StandardMazeBuilder()
        {
            maze = new Maze();

        }

        public void BuildDoor()
        {
            maze.Add("Standard Door builded");
        }

        public void BuildMaze()
        {
            maze.Add("Standard Maze builded");
        }

        public void BuildRoom()
        {
            maze.Add("Standard Room builded");
        }

        public Maze GetMaze()
        {
            return maze;
        }
    }
}
