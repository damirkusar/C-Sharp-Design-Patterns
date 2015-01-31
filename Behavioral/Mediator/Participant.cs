using System;

namespace Mediator
{
    public class Participant
    {
        private readonly string name;
        private Chatroom chatroom;

        public Participant(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public Chatroom Chatroom
        {
            get { return this.chatroom; }
            set { this.chatroom = value; }
        }

        public void Send(string to, string message)
        {
            this.chatroom.Send(this.name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, this.Name, message);
        }
    }
}