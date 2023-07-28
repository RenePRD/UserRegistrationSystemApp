// See https://aka.ms/new-console-template for more information

using UserRegistrationSystem;

IReadCommand<IUser, String> fileReadRegisteredUser = new FileReadRegisteredUser(); 
IWriteCommand<IUser> fileWriteRegisteredUser = new FileWriteRegisteredUser();
IInstance<User, IUser> userFactory = new UserFactory();

UserRegistrationController controller = new UserRegistrationController(fileReadRegisteredUser, fileWriteRegisteredUser, userFactory);

controller.RegisterNewUser("username1", "password1", Role.ADMIN);
controller.RegisterNewUser("username2", "password2", Role.USER);
controller.RegisterNewUser("username2", "password2", Role.USER);
controller.RegisterNewUser("username4", "password4", Role.NONE);
controller.RegisterNewUser("username5", "password5", Role.USER);


