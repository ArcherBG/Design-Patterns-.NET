using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        private string state;

        public void SetState(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return this.state;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(this.state);
        }

        public string GetStateFromMemento(Memento memento)
        {
            return memento.GetState();
        }

    }
}
