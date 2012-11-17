using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel.Partials
{
    public interface IProductDescription
    {
        ICategory Category { get; }
        string Description { get; }
    }
}
