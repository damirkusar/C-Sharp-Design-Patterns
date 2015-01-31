namespace Command
{
    public abstract class Command
    {
        protected Command(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        public Receiver Receiver { get; set; }

        public abstract void Execute();
    }
}