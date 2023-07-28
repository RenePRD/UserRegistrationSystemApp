using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public class UserRegistrationController
    {
        IReadCommand<IUser, string> fileReadRegisteredUser;
        IWriteCommand<IUser> fileWriteRegisteredUser;
        IInstance<User, IUser> factory;

        public UserRegistrationController(IReadCommand<IUser, string> fileReadRegisteredUser, IWriteCommand<IUser> fileWriteRegisteredUser, IInstance<User, IUser> factory)
        {
            this.fileReadRegisteredUser = fileReadRegisteredUser;
            this.fileWriteRegisteredUser = fileWriteRegisteredUser;
            this.factory = factory;
        }

        public void RegisterNewUser(string username, string password, Role role)
        {
            IUser userfound = fileReadRegisteredUser.ReadItem(username); 
            try
            {
                if (userfound != null)
                {
                    throw new UserRegistrationException("registration failed - username taken");
                }
                else
                {
                    IUser newUser = factory.Create();
                    newUser.Username = username;
                    newUser.Password = password;
                    newUser.Role = role;
                    fileWriteRegisteredUser.WriteItem(newUser);
                }
            } catch (UserRegistrationException ex)
            {
                Console.WriteLine($"{ex.GetType()}: {ex.Message}");
            }

        }
    }
}
