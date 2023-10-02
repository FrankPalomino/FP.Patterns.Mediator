namespace FP.Patterns.Mediator.Exercice1
{
    public class User
    {
        private IMediator _mediator;
        string Name { get; set; }

        public User(string name, IMediator mediator)
        {
            _mediator = mediator;
            Name = name;
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            System.Console.WriteLine($"{Name} Recibe message: {message}");
        }
    }
}
