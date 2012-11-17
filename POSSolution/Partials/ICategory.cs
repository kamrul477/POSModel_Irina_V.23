using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace POSModel
{
    public interface ICategory
    {
        Guid Id { get; }
        string Description { get; }
        Color Color { get; set; }
        Color FontColor { get; set; }
    }
}
