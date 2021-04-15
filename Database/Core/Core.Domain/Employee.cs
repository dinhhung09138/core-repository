using DotNetCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Employee : Entity<long>
    {
        public Employee
        (
            string firstName,
            string lastName,
            string email,
            User user,
            string badge,
            DateTime? resign,
            long? managerId
        )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            User = user;
            Activate();
            Badge = badge;
            Resign = resign;
            if (managerId != null)
            {
                Manager = new Employee(managerId.Value);
            }
        }

        public Employee
        (
            long id,
            string firstName,
            string lastName,
            string email,
            long userId,
            string badge,
            DateTime? resign,
            long departmentId,
            long divisionId,
            long employeeTypeId,
            long? managerId
        ) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserId = userId;
            Activate();
            Badge = badge;
            Resign = resign;
            DepartmentId = departmentId;
            DivisionId = divisionId;
            EmployeeTypeId = employeeTypeId;
            if (managerId != null)
            {
                Manager = new Employee(managerId.Value);
            }
        }
        public Employee(long id) : base(id) { }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; private set; }

        public Status Status { get; private set; }

        public User User { get; private set; }

        public long UserId { get; set; }

        public string Badge { get; set; }

        public long DepartmentId { get; set; }

        public long DivisionId { get; set; }

#pragma warning disable CS8632
        public Employee? Manager { get; set; }

        public long? ManagerId { get; set; }
#pragma warning restore CS8632

        public DateTime? Resign { get; set; }

        public long EmployeeTypeId { get; set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public string GetStatus()
        {
            switch (this.Status)
            {
                case Status.Active:
                    return "Active";
                case Status.Inactive:
                    return "Inactive";
                default:
                    return "None";
            }
        }
    }
}
