using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class Menu : IMenu
    {
        private Menu() { }

        //public Menu(Store store, string description)
        //{
        //    Store = store;
        //    Description = description;
        //}

        public Category AddCategory(string description)
        {
            foreach (var c in Categories)
            {
                if (c.Description.Equals(description))
                {
                    throw new Exception("Category is already exists");
                }
            }
            var category = new Category(description);
            Categories.Add(category);
            return category;
        }

        public Category FetchCategory(Guid id)
        {
            return Categories.First(c => c.Id == id);
        }

        public ProductDescription FetchCategoryProductDescription(Guid categoryId, Guid pdId)
        {
            var category = FetchCategory(categoryId);
            ProductDescription productDescription = null;

            if (category != null)
            {
                productDescription = category.FetchProductDescription(pdId);
            }
            return productDescription;
        }

        public ProductDescription AddProduct(Guid categoryId, string description, decimal basePrice, bool gstFree)
        {
            var category = FetchCategory(categoryId);
            return category.AddProductDescription(basePrice, description, gstFree);
        }

        public MenuProduct AddMenuProduct(Guid categoryId, Guid pdId)
        {
            var productDesciprtion = FetchCategoryProductDescription(categoryId, pdId);

            if (productDesciprtion == null)
            {
                throw new Exception("invalid product description");
            }

            var menuProduct = new MenuProduct(this.Id, pdId);
            MenuProducts.Add(menuProduct);
            return menuProduct;
        }

        public void RemoveProductMenu(Guid mpId)
        {
            var menuProduct = FetchMenuProduct(mpId);
            if (menuProduct == null)
            {
                throw new Exception("invalid");
            }
            MenuProducts.Remove(menuProduct);
        }

        public MenuProduct FetchMenuProduct(Guid mpId)
        {
            return MenuProducts.Where(mp => mp.Id == mpId).First();
        }

        // Irina added this to get list of menuProducts for each paticular category
       
        public MenuProduct[] GetCategoryMenuProducts(Guid catId)
        {
            var category = FetchCategory(catId);
            List<MenuProduct> categoryMenuProducts = new List<MenuProduct>();

            if (category != null)
            {
                foreach (var mp in this.MenuProducts)
                {
                    
                    if (mp.Category.Id.Equals(catId))
                    {
                        categoryMenuProducts.Add(mp);
                    }
                }
            }
            return categoryMenuProducts.ToArray();
        }

        IEnumerable<ICategory> IMenu.Categories
        {
            get 
            {
                return Categories;
            }
        }

        Guid IMenu.Id
        {
            get { return Id; }
        }
    }
}
