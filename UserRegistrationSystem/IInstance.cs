using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public interface IInstance<T, U> where T : U, new()
    {
        public U Create();

    }
}
