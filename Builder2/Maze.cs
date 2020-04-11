
using System;
using System.Collections.Generic;

namespace Builder2
{
    public class Maze
    {
        private List<string> maze = new List<string>();

        public void Add(string part)
        {
            maze.Add(part);
        }

        public void Show()
        {
            foreach (string part in maze)
                Console.WriteLine(part);
        }

    }
}
