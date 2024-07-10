namespace FP.Patterns.Mediator.Exercice4
{
    public interface IChatRoomMediator
    {
        void SendMessage(User user, string message);

        void AddUser(User user);
    }
}
