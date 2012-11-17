using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface IMenu
    {
        IEnumerable<ICategory> Categories { get; }
        Guid Id { get; }
    }
}
