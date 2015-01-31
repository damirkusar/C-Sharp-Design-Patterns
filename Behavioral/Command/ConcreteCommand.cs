namespace Command
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }

        public override void Execute()
        {
            this.Receiver.Action();
        }
    }
}