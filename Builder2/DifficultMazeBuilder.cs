using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    class DifficultMazeBuilder : IBuilder
    {
        private Maze maze;

        public DifficultMazeBuilder()
        {
            maze = new Maze();
        }

        public void BuildDoor()
        {
            maze.Add("Difficult Door builded");
        }

        public void BuildMaze()
        {
            maze.Add("Difficult Maze builded");
        }

        public void BuildRoom()
        {
            for (int i = 0; i < 4; i++)
            {
                BuildDoor();
            }
        }

        public Maze GetMaze()
        {
            return maze;
        }
    }
}
