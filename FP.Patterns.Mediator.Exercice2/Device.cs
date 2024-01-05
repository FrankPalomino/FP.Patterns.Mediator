namespace FP.Patterns.Mediator.Exercice2
{
    public abstract class Device
    {
        protected IMediator _mediator;

        protected Device(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Communicate(string message)
        {
            _mediator.Send(this, message);
        }

        public abstract void Receive(string  message);
    }
}
