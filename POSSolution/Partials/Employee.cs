using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
   internal partial class Employee: Person, IEmployee
    {
        private Employee() : base() { }

        public Employee(string firstName, string lastName, string password, IEnumerable<Permission> permissions) :
            base(firstName, lastName) { }


        public void EditPermissions(IEnumerable<Permission> permissions)
        {
            Permissions.Clear();
            Permissions.Concat(permissions);
        }

        Guid IEmployee.Id
        {
            get { return this.Id; }
        }

        string IEmployee.FirstName
        {
            get { return this.FirstName; }
        }
        
        string IEmployee.LastName
        {
            get { return this.LastName; }
        }

        string IEmployee.Password
        {
            get { return this.Password; }
        }

        IEnumerable<IPermission> IEmployee.Permissions
        {
            get { return Permissions; }
        }
             
   }
}
