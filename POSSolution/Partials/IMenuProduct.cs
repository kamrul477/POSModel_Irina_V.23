using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel.Partials;

namespace POSModel
{
    public  interface IMenuProduct
    {
        Guid Id { get; }
        //ICategory Category { get; }
        string Description { get; }
    }
}
