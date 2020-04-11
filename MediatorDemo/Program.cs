using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User john = new User("John");
            User Sara = new User("Sara");

            john.SendMessage("Hello Sara.");
            Sara.SendMessage("Hi John. How are you?");

            Console.ReadKey();
        }
    }
}
