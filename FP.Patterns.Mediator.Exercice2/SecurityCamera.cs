namespace FP.Patterns.Mediator.Exercice2
{
    public class SecurityCamera : Device
    {
        public SecurityCamera(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"SecurityCamera Receive: {message}");
        }
    }
}
