namespace FP.Patterns.Mediator
{
    public class User : Colleague
    {
        public User(IMediator mediator) : base(mediator)
        {
        }
        public override void Receive(string message)
        {
            System.Console.WriteLine($"User received message: {message}");
        }
    }
}
