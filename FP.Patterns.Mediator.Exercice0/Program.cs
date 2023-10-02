using FP.Patterns.Mediator;

Mediator mediator = new Mediator();

Colleague user = new User(mediator);
Colleague admin = new UserAdmin(mediator);
Colleague admin2 = new UserAdmin(mediator);

mediator.AddColleague(user);
mediator.AddColleague(admin);
mediator.AddColleague(admin2);

user.Communicate("Hello Admins!");