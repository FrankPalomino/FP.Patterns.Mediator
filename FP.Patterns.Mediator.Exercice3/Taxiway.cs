namespace FP.Patterns.Mediator.Exercice3
{
    public class Taxiway : Component
    {
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"Taxiway received: {message}");
        }
    }
}
