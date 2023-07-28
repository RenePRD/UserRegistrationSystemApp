﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public interface IUser
    {
        public string Username {  get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
