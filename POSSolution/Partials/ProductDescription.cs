using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel.Partials;

namespace POSModel
{
    internal partial class ProductDescription: IProductDescription
    {
       private ProductDescription() { }

       public ProductDescription(Category category, decimal basePrice, string description, bool gstFree)
       {
           this.Category = category;
           this.BasePrice = basePrice;
           this.Description = description;
           this.Gst_Free = gstFree;
       }

       ICategory IProductDescription.Category
       {
           get { return this.Category; }
       }

       string IProductDescription.Description
       {
           get { return this.Description; }
       }

    }
}
