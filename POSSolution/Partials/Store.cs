using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel.Partials;

namespace POSModel
{
    internal partial class Store: IStore
    {
        private Store() { }

        public Store(string description)
        {
            Description = description;
        }


        /*public Area AddArea(string description)
        {
            var area = new Area(description, this);
            Areas.Add(area);
            return area;
        }*/

        /*public Menu AddMenu(string description)
         {
            var menu = new Menu(description, this);
            Menus.Add(menu);
            return menu;
         }*/   

        IEnumerable<IMenu> IStore.Menus
        {
            get { return Menus ; }
        }

        public ICompany GetCompany()
        {
            return (Company as ICompany);
        }

        #region Employee Methods
        
        public void RegisterEmployee(Employee emp)
        {
            Employees.Add(emp as Employee);
        }

        public void RemoveEmployee(Employee emp)
        {
            Employees.Remove(emp);
        }

        //public void AddPermissionToEmployee(Employee emp, Permission permission)
        //{
        //    emp.AddPermission(permission);
        //}

        //public void RemoveEmployeePermission(Employee emp, Permission permission)
        //{
        //    emp.RemovePermission(permission);
        //}

        public void EditPermissions(Employee employee, IEnumerable<Permission> permissions)
        {
            employee.EditPermissions(permissions);
        }
        #endregion
        
        #region Sale Methods

        public Sale CreateNewSale(Employee employee, Guid tableAreaId, Guid tableId, Guid terminlaAreaId, Guid terminalId, int covers)
        {
            var tableArea = Areas.First(tArea => tArea.Id == tableAreaId);
            var table = tableArea.GetTable(tableId);
            var terminalArea = Areas.First(termArea => termArea.Id == terminlaAreaId);

            return terminalArea.CreateANewSale(employee, table, terminalId, covers);
        }

        public Sale TakeAwaySale(Employee employee, Guid terminalId, Guid terminalAreaId)
        {
            var area = this[terminalAreaId];
            return area.TakeAwaySale(employee, terminalId);
        }

        public SaleLineItem AddSaleLineItem(Employee employee, Guid saleId,Guid menuId, Guid productId, Guid terminalId, Guid terminalAreaId)
        {
            var menuProduct = findMenuProductById(menuId,productId);
            var terminalArea = this[terminalAreaId];
            return terminalArea.AddSaleLineItem(employee, saleId, menuProduct, terminalId);
        }

        public bool RemoveSaleLineItem(Employee employee, Guid saleId,Guid menuId, Guid productId, Guid terminalId, Guid terminalAreaId)
        {
            var product = findMenuProductById(menuId,productId);
            var terminalArea = this[terminalAreaId];
            return terminalArea.RemoveSaleLineItem(employee, saleId, product, terminalId);
        }

        public void IncrementQty(Employee employee, Guid saleId,Guid menuId, Guid productId, Guid terminalId, Guid terminalAreaId)
        {
            var product = findMenuProductById(menuId,productId);
            var area = this[terminalAreaId];
            area.IncrementQty(employee, saleId, product, terminalId);
        }

        public void DecrementQty(Employee employee, Guid saleId,Guid menuId, Guid productId, Guid terminalId, Guid terminalAreaId)
        {
            var product = findMenuProductById(menuId,productId);
            var area = this[terminalAreaId];
            area.DecrementQty(employee, saleId, product, terminalId);
        }

        public void ChangeQty(Employee employee, Guid saleId, Guid menuId,Guid productId, Guid terminalId, Guid terminalAreaId, int qty)
        {
            var product = findMenuProductById(menuId,productId);
            var area = this[terminalAreaId];
            area.ChangeQty(employee, saleId, product, terminalId, qty);
        }

        public bool RemoveSale(Employee employee, Guid saleId, Guid tableId, Guid terminalId, Guid terminalAreaId)
        {
            var area = this[terminalAreaId];
            return area.RemoveSale(employee, saleId, tableId, terminalId);
        }

        public void ChangeCovers(Guid terminalAreaId, Guid terminalId, Guid saleId, int covers, Employee employee)
        {
            var area = this[terminalAreaId];
            area.ChangeCovers(terminalId, saleId, covers, employee);
        }

        private MenuProduct findMenuProductById(Guid menuId,Guid productId)
        {
            var menu = getMenu(menuId);            
            return (from mp in menu.MenuProducts where mp.Id == productId select mp).First();
        }

        public bool AddCashPayment(Guid saleId, decimal amount, Employee employee, Guid terminalAreaId, Guid terminalId)
        {
            var area = this[terminalAreaId];
            return area.AddCashPayment(saleId, amount, employee, terminalId);
        }

        public bool AddEftposPayment(Guid saleId, decimal amount, Employee employee, Guid terminalAreaId, Guid terminalId)
        {
            var area = this[terminalAreaId];
            return area.AddEftposPayment(saleId, amount, employee, terminalId);
        }

        public bool RemovePayment(Guid saleId, Guid paymentId, Employee employee, Guid terminalAreaId, Guid terminalId)
        {
            var area = this[terminalAreaId];
            return area.RemovePayment(saleId, paymentId, employee, terminalId);
        }

        public Sale MoveSaleFromTable(Guid terminalAreaId, Guid terminalId, Guid tableAreaId, Guid tableId)
        {
            var terminalArea = this[terminalAreaId];
            var tableArea = this[tableAreaId];
            var table = tableArea.GetTable(tableId);
            return terminalArea.MoveSaleFromTable(table, terminalId);
        }

        public void MoveSaleToTable(Guid tableAreaId, Guid tableId, Guid terminalAreaId, Guid terminalId, Guid saleId)
        {
            var tableArea = this[tableAreaId];
            var table = tableArea.GetTable(tableId);
            var terminalArea = this[terminalAreaId];
            terminalArea.MoveSaletoTable(table, terminalId, saleId);
        }

        public Category FetchCategory(Guid menuId, Guid catId)
        {
            var menu = Menus.First(m => m.Id == menuId);
            return menu.FetchCategory(catId);
        }

        public MenuProduct[] GetCategoryMenuProducts(Guid menuId, Guid catId)
        {
            var menu = Menus.First(m => m.Id == menuId);
            return menu.GetCategoryMenuProducts(catId);
        }
        #endregion
        
        #region Product Methods

        public ProductDescription AddProduct(Guid menuId, Guid categoryId, string description, decimal basePrice, bool gstFree)
        {
            var menu = getMenu(menuId);
            return menu.AddProduct(categoryId, description, basePrice, gstFree);
        }

        public MenuProduct AddProductToMenu(Guid menuId, Guid categoryId, Guid productDescriptionId)
        {
            var menu = getMenu(menuId);
            return menu.AddMenuProduct(categoryId, productDescriptionId);
        }

        public void RemoveProductFromMenu(Guid menuId, Guid menuProductId)
        {
            var menu = getMenu(menuId);
            menu.RemoveProductMenu(menuProductId);
        }


        internal Menu getMenu(Guid menuId)
        {
            return Menus.First(m => m.Id == menuId);
        }

        #endregion

        public void OpenTable(Guid tableAreaId, Guid tableId)
        {
            var tableArea = this[tableAreaId];
            tableArea.OpenTable(tableId);
        }
        public void CloseTable(Guid tableAreaId, Guid tableId)
        {
            var tableArea = this[tableAreaId];
            tableArea.CloseTable(tableId);
        }

        public Area AddArea(string description)
        {
            var area = new Area(description, this);
            Areas.Add(area);
            return area;
        }

        private Area this[Guid areaId]
        {
            get { return Areas.First(a => a.Id == areaId); }
        }
        
        public IEnumerable<IEmployee> StoreEmployees
        {
            get { return Employees; }
        }

        public IEnumerable<ICategory> GetCategories(Guid menuId)
        {
            var menu = getMenu(menuId);
            return menu.Categories;
        }

        public Table GetTable(Guid tableAreaId, Guid tableId)
        {
            var tableArea = this[tableAreaId];
            return tableArea.GetTable(tableId);
        }

        public IEnumerable<Table> GetTablesInArea(Guid areaId)
        {
            var area = this[areaId];
            return area.Tables.ToList();
        }


        public Guid productId { get; set; }

        public Sale GetSale(Guid terminalId, Guid terminlaAreaId, Guid saleId)
        {
            var area = this[terminlaAreaId];
            return area.GetSale(terminalId, saleId);
        }
    }
}
