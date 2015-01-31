using System;

namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create chatroom
            var chatroom = new Chatroom();

            // Create participants and register them
            var george = new Beatle("George");
            var paul = new Beatle("Paul");
            var ringo = new Beatle("Ringo");
            var john = new Beatle("John");
            var yoko = new NonBeatle("Yoko");

            chatroom.Register(george);
            chatroom.Register(paul);
            chatroom.Register(ringo);
            chatroom.Register(john);
            chatroom.Register(yoko);

            // Chatting participants
            yoko.Send("John", "Hi John!");
            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
            john.Send("Yoko", "My sweet love");

            // Wait for user
            Console.ReadKey();
        }
    }
}
