namespace FP.Patterns.Mediator.Exercice4
{
    public class ChatRoomMediator : IChatRoomMediator
    {
        private List<User> _users;

        public ChatRoomMediator()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(User user, string message)
        {
            foreach(var usr in _users)
            {
                if (!user.UserName.Equals(usr.UserName))
                {
                    usr.GetMessage(message, user.UserName);
                }
            }
        }
    }
}
