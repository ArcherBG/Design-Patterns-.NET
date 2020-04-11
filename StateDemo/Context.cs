using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    public class Context
    {
        private IState state;
        public Context()
        {
            this.state = null;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetState()
        {
            return this.state;
        }
    }
}
