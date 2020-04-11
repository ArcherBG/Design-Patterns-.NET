using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    public class NameRepository: IContainer
    {
        public static string[] names = { "Jack", "Samanta", "Tom" };

        public IIterator GetIterator()
        {
            return new Iterator();
        }


        private class Iterator : IIterator
        {
            int index;
            public bool HasNext()
            {
                if(index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object Next()
            {
                if (this.HasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
