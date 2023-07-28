using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public class FileWriteRegisteredUser : IWriteCommand<IUser>
    {
        private FileInfo fileInfo;
        private string destination = RegisteredUsersFileUtility.RegisteredUsersPath;
        private string delimiter = RegisteredUsersFileUtility.UserRecordDelimeter;

        public void WriteItem(IUser item)
        {
            var destFileInfo = new FileInfo(destination);
            //using (StreamReader sr = this.fileInfo.OpenText())
            using (StreamWriter sw = destFileInfo.AppendText())
            {
                sw.WriteLine($"{item.Username}{delimiter}{item.Password}{delimiter}{item.Role}");
            }
        }
    }
}
