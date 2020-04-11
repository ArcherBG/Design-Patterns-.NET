using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmployee
{
    class Employee
    {
        private string name;
        private int salary;
        private List<Employee> subordinates;

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
            this.subordinates = new List<Employee>();
        }

        public void add(Employee e)
        {
            subordinates.Add(e);
        }

        public void remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return subordinates;
        }

        public string toString()
        {
            return ("Employee :[ Name : " + name + ", salary :" + salary + " ]");
        }

    }
}

