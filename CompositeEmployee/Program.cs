using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmployee
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee CEO = new Employee("Robert", 100000);
            Employee teamLead = new Employee("Michel", 5000);
            Employee clerk1 = new Employee("Laura", 2000);
            Employee clerk2 = new Employee("Bob", 2000);

            CEO.add(teamLead);
            teamLead.add(clerk1);
            teamLead.add(clerk2);

            Console.WriteLine(CEO);

            for (int i = 0; i < CEO.getSubordinates().Count; i++)
            {
                var list = CEO.getSubordinates();
                Console.WriteLine(list[i]);
            }
        }
    }
}
