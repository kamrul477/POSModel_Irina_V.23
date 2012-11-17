using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface IStore
    {
        Guid Id { get; }
        string Description { get; }
        IEnumerable<IEmployee> StoreEmployees { get; }
        IEnumerable<IMenu> Menus { get; }
    }
}
