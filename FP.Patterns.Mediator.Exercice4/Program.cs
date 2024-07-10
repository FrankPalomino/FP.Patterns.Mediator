using FP.Patterns.Mediator.Exercice4;

ChatRoomMediator chatRoom = new ChatRoomMediator();
User frank = new(chatRoom, "Frank");
User vero = new(chatRoom, "Vero");
User pili = new(chatRoom, "Pili");

chatRoom.AddUser(frank);
chatRoom.AddUser(vero);
chatRoom.AddUser(pili);

frank.SendMessage("Hello");
vero.SendMessage("Hi EveryOne");
pili.SendMessage("Hello guys");