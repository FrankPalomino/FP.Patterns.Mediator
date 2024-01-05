using FP.Patterns.Mediator.Exercice2;

namespace FP.Patterns.Mediator
{
    public class Light : Device
    {
        public Light(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Light Receive: {message}");
        }
    }
}
