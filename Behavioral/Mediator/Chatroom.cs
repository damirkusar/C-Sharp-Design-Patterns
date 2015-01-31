using System.Collections.Generic;

namespace Mediator
{
    public class Chatroom : AbstractChatroom
    {
        private readonly Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!this.participants.ContainsValue(participant))
            {
                this.participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            var participant = this.participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}