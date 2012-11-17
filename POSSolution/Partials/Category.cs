using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace POSModel
{
    internal partial class Category: ICategory
    {
       private Category() { }

       private Color _color;
       private Color _font;

       public Category(string description)
       {
           Description = description;
       }

       public ProductDescription FetchProductDescription(Guid id)
       {
           return ProductDescriptions.Where(pd => pd.Id == id).First();
       }

       public ProductDescription AddProductDescription(decimal basePrice, string description, bool gstFree)
       {
           var pd = new ProductDescription(this, basePrice, description, gstFree);

           if (ProductDescriptions.Contains(pd))
           {
               throw new Exception(" Product already exists");
           }

           ProductDescriptions.Add(pd);
           return pd;
       }

       Guid ICategory.Id
       {
           get { return Id; }
       }


       string ICategory.Description
       {
           get { return Description; }
       }


       public Color Color
       {
           get
           {
               return _color;
           }
           set
           {
               _color = value;
           }
       }

       public Color FontColor
       {
           get
           {
               return _font;
           }
           set
           {
               _font = value;
           }
       }


    }
}
