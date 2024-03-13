namespace FP.Patterns.Mediator.Exercice3
{
    public interface IMediator
    {
        void Register(Component component);
        void SendMessage(Component sender, string message);
    }
}
