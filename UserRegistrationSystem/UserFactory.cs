using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserRegistrationSystem
{
     public class UserFactory : IInstance<User, IUser>
    {
        public IUser Create()
        {           
            return new User();
        }
    }
}
