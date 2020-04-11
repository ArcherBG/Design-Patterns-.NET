using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            NameRepository nameRepository = new NameRepository();

            for(IIterator iterator = nameRepository.GetIterator(); iterator.HasNext(); )
            {
                string name = (string)iterator.Next();
                Console.WriteLine("Name is: " + name);
            }

            Console.ReadKey();
        }
    }
}
