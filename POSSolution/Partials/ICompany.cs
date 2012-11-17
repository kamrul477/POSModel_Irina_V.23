using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface ICompany
    {
        Guid Id { get; }
        string Description { get; }
        long ABN { get; }
        string Address { get; }
        IStore Store { get; }
    }
}
