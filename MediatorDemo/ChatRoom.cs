using System;

namespace MediatorDemo
{
    public class ChatRoom
    {

        public static void SendMessage(User user, string message)
        {
            Console.WriteLine("User: " + user.Name + " types: " + message);
        }
    }
}