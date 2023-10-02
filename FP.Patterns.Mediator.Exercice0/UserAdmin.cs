namespace FP.Patterns.Mediator
{
    public class UserAdmin : Colleague
    {
        public UserAdmin(IMediator mediator) : base(mediator)
        {
        }
        public override void Receive(string message)
        {
            System.Console.WriteLine($"UserAdmin received message: {message}");
        }
    }
}
