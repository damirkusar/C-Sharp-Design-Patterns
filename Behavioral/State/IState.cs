namespace State
{
    public interface IState
    {
        IState Update();

        IState Cancel();
    }
}