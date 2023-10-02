using FP.Patterns.Mediator.Exercice1;

ChatRoom chatRoom = new ChatRoom();

User user = new User("User1", chatRoom);
User user2 = new User("User2", chatRoom);
User user3 = new User("User3", chatRoom);

chatRoom.AddUser(user);
chatRoom.AddUser(user2);
chatRoom.AddUser(user3);

user.Send("Hello everyone!");