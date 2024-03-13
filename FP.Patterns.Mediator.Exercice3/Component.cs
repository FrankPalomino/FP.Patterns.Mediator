namespace FP.Patterns.Mediator.Exercice3
{
    public abstract class Component
    {
        protected IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void SendMessage(string message)
        {
            mediator.SendMessage(this, message);
        }

        public abstract void ReceiveMessage(string message);
    }
}