using System;
using System.Collections.Generic;
using System.Text;
using DotNetCore.Domain;

namespace Core.Domain
{
    public class User : Entity<long>
    {
        public User
        (
            long id,
            string login,
            string password
        ) : base(id)
        {
            Login = login;
            Password = password;
            Salt = Guid.NewGuid().ToString();
        }

        public User(long id) : base(id) { }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public string Salt { get; private set; }

        public virtual Employee Employee { get; set; }

        public void UpdatePassword(string password)
        {
            Password = password;
        }

    }
}
