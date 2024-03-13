namespace FP.Patterns.Mediator.Exercice3
{
    public class Runway : Component
    {
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"Runway received: {message}");
        }
    }
}
