using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public class FileReadRegisteredUser : IReadCommand<IUser, string>
    {
        private string source = RegisteredUsersFileUtility.RegisteredUsersPath;
        private string delimiter = RegisteredUsersFileUtility.UserRecordDelimeter;
        private FileInfo fileInfo;

        public IUser ReadItem(string id)
        {
            fileInfo = new FileInfo(source);
            using (StreamReader sr = fileInfo.OpenText())
            {
                var line = sr.ReadLine();
                while (!object.ReferenceEquals(line, null))
                {
                    string[] words = line.Split(delimiter);
                    if ((words.Length > 0) && (words[0] == id))
                    {
                        IUser userFound = new User();
                        userFound.Username = words[0];
                        userFound.Password = words[1];
                        if (Enum.TryParse(words[2], out Role role))
                                userFound.Role = role;
                        else
                                Console.WriteLine("Invalid Role type");

                        Console.WriteLine($"user with username {id} found");
                        return userFound;
                    }
                    line = sr.ReadLine();
                }

                Console.WriteLine("No user found");
                return null;
            }
        }
    }
}
