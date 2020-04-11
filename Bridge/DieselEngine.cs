using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class DieselEngine : IEngine
    {
        private const string type = "diesel";

        private String GetType()
        {
            return type;
        }

        public IEngine GetEngine(string type)
        {
            return this;
        }
    }
}
