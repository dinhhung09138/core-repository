using System;
using DotNetCore.Domain;

namespace Core.Domain
{
    public sealed class Employee : Entity<long>
    {
        public Employee() { }


        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime Birthday { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }
    }
}
