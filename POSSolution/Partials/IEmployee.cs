using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface IEmployee
    {
        Guid Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string Password { get; }
        IEnumerable<IPermission> Permissions { get; }
    }
}
