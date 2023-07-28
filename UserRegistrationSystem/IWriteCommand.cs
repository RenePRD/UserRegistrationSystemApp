using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public interface IWriteCommand<T>
    {
        public void WriteItem(T item);

    }
}
