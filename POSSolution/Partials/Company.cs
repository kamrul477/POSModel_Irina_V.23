using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class Company: ICompany
    {
        private Employee _employee;
        private Company() { }
		public Company(string description, long abn, string address) 
		{
			Description = description;
            ABN = abn;
            Address = address;
		}

        IStore ICompany.Store
        {
            get
            {
                return Store;
            }
        }

        private Store Store
        {
            get
            {
                return Stores.First();
            }
        }

        #region Employee
        public Employee AddEmployee(string firstName, string lastName, string password, IEnumerable<Permission> permissions)
        {
            Employee emp = new Employee(firstName, lastName, password, permissions);
            People.Add(emp);
            return emp;
        }

        public void RemoveEmployee(Guid employeeID)
        {
            var emp = ((from e in People where e.Id == employeeID select e).First()) as Employee;

            foreach (Store s in Stores)
            {
                s.RemoveEmployee(emp);
            }
        }

        public void EditPermissions(Guid storeId, Guid employeeId, IEnumerable<Permission> permissions)
        {
            var employee = (People.First(e => e.Id == employeeId)) as Employee;
            var store = this[storeId];
            store.EditPermissions(employee, permissions);
        }

        public bool AuthenticateEmployee(Guid employeeId, string password)
        {
            var employee = (from p in People where p.Id == employeeId select p).First() as Employee;
            if (employee != null && employee.Password.Equals(password))
            {
                currentLoggedInEmployee = employee;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetEmployee(Guid employeeId)
        {
            return People.First(e => e.Id == employeeId) as Employee;
        }

        public IEnumerable<IEmployee> GetEmployees(Guid storeId)
        {
            var store = this[storeId];
            return store.StoreEmployees;
        }

        internal Employee currentLoggedInEmployee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
            }
        }

        public IEmployee CurrentLoggedInEmployee
        {
            get
            {
                return _employee;
            }
        }

        #endregion

        #region Sale
        public Sale CreateNewSale(Guid employeeId, Guid storeId, Guid tableAreaId, Guid tableId, Guid terminalId, Guid terminlaAreaId, int covers)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);

            return store.CreateNewSale(employee, tableAreaId, tableId, terminlaAreaId, terminalId, covers);
        }
        public Sale TakeAwaySale(Guid employeeId, Guid storeId, Guid terminalId, Guid terminlaAreaId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);

            return store.TakeAwaySale(employee, terminalId, terminlaAreaId);
        }

        public SaleLineItem AddSaleLineItem(Guid employeeId, Guid storeId, Guid saleId, Guid menuId,Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);

            return store.AddSaleLineItem(employee, saleId,menuId, menuProductId, terminalId, terminalAreaId);
        }
        public bool RemoveSaleLineItem(Guid employeeId, Guid storeId, Guid saleId,Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var employee = GetEmployee(employeeId);

            return this[storeId].RemoveSaleLineItem(employee, saleId,menuId, menuProductId, terminalId, terminalAreaId);
        }
        public void IncrementQty(Guid employeeId, Guid storeId, Guid saleId,Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);

            store.IncrementQty(employee, saleId,menuId, menuProductId, terminalId, terminalAreaId);
        }
        public void DecrementQty(Guid employeeId, Guid storeId, Guid saleId,Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);

            store.DecrementQty(employee, saleId,menuId, menuProductId, terminalId, terminalAreaId);
        }
        public void ChangeQty(Guid employeeId, Guid storeId, Guid saleId,Guid menuId,Guid terminalId, Guid terminalAreaId, Guid menuProductId, int qty)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);

            store.ChangeQty(employee, saleId, menuId,menuProductId, terminalId, terminalAreaId, qty);
        }
        public bool RemoveSale(Guid employeeId, Guid storeId, Guid saleId, Guid tableId, Guid terminalId, Guid terminalAreaId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);

            return store.RemoveSale(employee, saleId, tableId, terminalId, terminalAreaId);
        }

        public void ChangeCovers(Guid storeId, Guid terminalAreaId, Guid terminalId, Guid saleId, int covers, Guid employeeId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);
            store.ChangeCovers(terminalAreaId, terminalId, saleId, covers, employee);
        }


        public bool AddCashPayment(Guid storeId, Guid saleId, decimal amount, Guid employeeId, Guid terminalAreaId, Guid terminalId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);
            return store.AddCashPayment(saleId, amount, employee, terminalAreaId, terminalId);
        }

        public bool AddEftposPayment(Guid storeId, Guid saleId, decimal amount, Guid employeeId, Guid terminalAreaId, Guid terminalId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);
            return store.AddEftposPayment(saleId, amount, employee, terminalAreaId, terminalId);
        }

        public bool RemovePayment(Guid storeId, Guid saleId, Guid paymentId, Guid employeeId, Guid terminalAreaId, Guid terminalId)
        {
            var store = this[storeId];
            var employee = GetEmployee(employeeId);
            return store.RemovePayment(saleId, paymentId, employee, terminalAreaId, terminalId);
        }

        public Sale MoveSaleFromTable(Guid storeId, Guid terminalAreaId, Guid tableAreaId, Guid terminalId, Guid tableId)
        {
            var store = this[storeId];
            return store.MoveSaleFromTable(terminalAreaId, terminalId, tableAreaId, tableId);

        }
        public void MoveSaleToTable(Guid storeId, Guid terminalAreaId, Guid tableAreaId, Guid terminalId, Guid tableId, Guid saleId)
        {
            var store = this[storeId];
            store.MoveSaleToTable(tableAreaId, tableId, terminalAreaId, terminalId, saleId);
        }

        public Category FetchCategory(Guid storeId, Guid menuId, Guid catId)
        {
            var store = this[storeId];
            return store.FetchCategory(menuId, catId);
        }

        public MenuProduct[] GetCategoryMenuProducts(Guid storeId, Guid menuId, Guid catId)
        {
            var store = this[storeId];
            return store.GetCategoryMenuProducts(menuId, catId);
        }
        #endregion

        #region Product
        public ProductDescription AddProduct(Guid storeId, Guid menuId, Guid categoryId, string description, decimal basePrice, bool gstFree)
        {
            var store = this[storeId];
            return store.AddProduct(menuId, categoryId, description, basePrice, gstFree);
        }

        public MenuProduct AddProductToMenu(Guid storeId, Guid menuId, Guid categoryId, Guid productDescriptionId)
        {
            var store = this[storeId];
            return store.AddProductToMenu(menuId, categoryId, productDescriptionId);
        }

        public void RemoveProductFromMenu(Guid storeId, Guid menuId, Guid menuProductId)
        {
            var store = this[storeId];
            store.RemoveProductFromMenu(menuId, menuProductId);
        }


        public IEnumerable<ICategory> GetCategories(Guid storeId, Guid menuId)
        {
            var store = this[storeId];
            return store.GetCategories(menuId); ;
        }

        #endregion


        #region TableState
        public void OpenTable(Guid storeId, Guid tableAreaId, Guid tableId)
        {
            var store = this[storeId];
            store.OpenTable(tableAreaId, tableId);
        }
        public void CloseTable(Guid storeId, Guid tableAreaId, Guid tableId)
        {
            var store = this[storeId];
            store.CloseTable(tableAreaId, tableId);
        }
        #endregion


        internal Store this[Guid storeId]
        {
            get
            {
                return (Stores.First(s => s.Id == storeId));
            }
        }

        public Table GetTable(Guid storeId, Guid tableAreaId, Guid tableId)
        {
            var store = this[storeId];
            return store.GetTable(tableAreaId, tableId);
        }

        public IEnumerable<Area> GetAreasOFStore(Guid storeId)
        {
            var store = this[storeId];
            return store.Areas.ToList();
        }

        public IEnumerable<Table> GetTablesInArea(Guid storeId, Guid areaId)
        {
            var store = this[storeId];
            return store.GetTablesInArea(areaId);
        }


        public Sale GetSale(Guid storeId, Guid terminalId, Guid terminlaAreaId, Guid saleId)
        {
            var store = this[storeId];
            return store.GetSale(terminalId, terminlaAreaId,saleId);
        }
    }
}
