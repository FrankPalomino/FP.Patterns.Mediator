namespace FP.Patterns.Mediator.Exercice1
{
    public class ChatRoom: IMediator
    {
        private List<User> _users;

        public ChatRoom()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void Send(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
