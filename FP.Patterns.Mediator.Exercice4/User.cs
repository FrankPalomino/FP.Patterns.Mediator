namespace FP.Patterns.Mediator.Exercice4
{
    public class User
    {
        private readonly IChatRoomMediator _chatRoomMediator;
        public string UserName { get; set; }

        public User(IChatRoomMediator chatRoomMediator, string username)
        {
            _chatRoomMediator = chatRoomMediator;
            UserName = username;
        }

        public void SendMessage(string message)
        {
            _chatRoomMediator.SendMessage(this, message);
        }

        public void GetMessage(string message, string userName)
        {
            Console.WriteLine($"Message to {UserName} \n {userName} says: {message}");
        }
    }
}
