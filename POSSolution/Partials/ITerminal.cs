using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface ITerminal
    {
        Guid Id { get; }
        string Description { get; }
        IEnumerable<ISale> Sales { get; }
        ICompany Company { get; }
        IStore Store { get; }
        IArea Area { get; }
    }
}
