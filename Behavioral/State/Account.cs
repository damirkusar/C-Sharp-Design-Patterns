namespace State
{
    public class Account
    {
        private string name;
        private IState state;

        public Account(string name)
        {
            this.Name = name;
            this.State = new FreemiumState();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public IState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void UpdateStatus()
        {
            this.state = this.state.Update();
        }

        public void CancelSubsription()
        {
            this.state = this.state.Cancel();
        }
    }
}