using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface IMenuProductTemperal
    {
        decimal Price {get;}
        DateTime EffectiveFrom { get; }
    }
}
