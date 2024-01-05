namespace FP.Patterns.Mediator.Exercice2
{
    public class Thermostat : Device
    {
        public Thermostat(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Thermostat Receive: {message}");
        }
    }
}
