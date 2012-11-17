using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface IPermission
    {
        Guid Id { get; }
        string Description { get; }
        string code {get;}
    }
}
