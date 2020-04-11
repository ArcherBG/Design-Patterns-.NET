using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    class DirectorBuilder
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildDoor();
            builder.BuildRoom();
            builder.BuildMaze();
        }

    }
}
