namespace FP.Patterns.Mediator.Exercice3
{
    public class Hangar : Component
    {
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"Hangar received: {message}");
        }
    }
}
