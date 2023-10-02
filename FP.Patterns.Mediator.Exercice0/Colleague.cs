namespace FP.Patterns.Mediator
{
    public abstract class Colleague
    {
        private IMediator _mediator;

        public IMediator Mediator { get; }

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Communicate(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Receive(string message);
    }
}