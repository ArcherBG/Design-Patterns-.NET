using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public class User
    {
        public string Name { get; set;}

        public User(string name)
        {
            this.Name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.SendMessage(this, message);
        }
    }
}
