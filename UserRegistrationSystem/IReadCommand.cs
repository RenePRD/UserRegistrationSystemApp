using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public interface IReadCommand<T, U>
    {
        public T ReadItem(U id);
    }
}
