namespace FP.Patterns.Mediator
{
    public interface IMediator
    {
        public void Send(string message, Colleague colleague);
    }
}
