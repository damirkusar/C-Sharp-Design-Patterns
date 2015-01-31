namespace ChainOfResponsibility
{
    public abstract class Approver
    {
        public Approver Successor { get; set; }

        public void SetSuccessor(Approver successorRole)
        {
            this.Successor = successorRole;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}