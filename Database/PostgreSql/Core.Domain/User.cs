using System;
using System.Collections.Generic;
using DotNetCore.Domain;

namespace Core.Domain
{
    public class User : Entity<long>
    {
        public User() { }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
