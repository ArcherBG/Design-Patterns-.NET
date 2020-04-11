using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CareTaker
    {
        private List<Memento> list = new List<Memento>();

        public void Add(Memento memento)
        {
            this.list.Add(memento);
        }

        public Memento Get(int index)
        {
            if (index < 0 || index >= this.list.Count)
            {
                return null;
            }
            return this.list[index];
        }

    }
}
