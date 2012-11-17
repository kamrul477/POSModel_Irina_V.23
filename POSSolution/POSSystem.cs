using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using POSModel.Partials; 

namespace POSModel
{
    public class POSSystem: IDisposable
    {
        private static POSDBEntities _context;

        private static POSSystem _system = new POSSystem();

        public static POSSystem Instance
        {
            get
            {
                _context = new POSDBEntities();
                return _system;
            }
        }

        #region Sale

        public ISale CreateNewSale(Guid companyId, Guid employeeId, Guid storeId, Guid tableAreaId, Guid tableId, Guid terminalId, Guid terminlaAreaId, int covers)
        {
            var company = getCompany(companyId);
            var sale =  company.CreateNewSale(employeeId, storeId, tableAreaId, tableId, terminalId, terminlaAreaId, covers);
            _context.SaveChanges();
            return sale;
        }

        public ISale TakeAwaySale(Guid companyId, Guid employeeId, Guid storeId, Guid terminalId, Guid terminlaAreaId)
        {
            var company = getCompany(companyId);
            var sale = company.TakeAwaySale(employeeId, storeId, terminalId, terminlaAreaId);
            _context.SaveChanges();
            return sale;
        } 

        public ISaleLineItem AddSaleLineItem(Guid companyId, Guid employeeId, Guid storeId, Guid saleId, Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var company = getCompany(companyId);
            var sli = company.AddSaleLineItem(employeeId, storeId, saleId, menuId, terminalId, terminalAreaId, menuProductId);
            _context.SaveChanges();
            return sli;
        }

        public bool RemoveSaleLineItem(Guid companyId, Guid employeeId, Guid storeId, Guid saleId, Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var company = getCompany(companyId);
            var result =  company.RemoveSaleLineItem(employeeId, storeId, saleId, menuId, terminalId, terminalAreaId, menuProductId);
            _context.SaveChanges();
            return result;
        }

        public void IncrementQty(Guid companyId, Guid employeeId, Guid storeId, Guid saleId, Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var company = getCompany(companyId);
            company.IncrementQty(employeeId, storeId, saleId, menuId, terminalId, terminalAreaId, menuProductId);
            _context.SaveChanges();
        }

        public void DecrementQty(Guid companyId, Guid employeeId, Guid storeId, Guid saleId, Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId)
        {
            var company = getCompany(companyId);
            company.DecrementQty(employeeId, storeId, saleId, menuId,terminalId, terminalAreaId, menuProductId);
            _context.SaveChanges();
        }

        public void ChangeQty(Guid companyId, Guid employeeId, Guid storeId, Guid saleId, Guid menuId, Guid terminalId, Guid terminalAreaId, Guid menuProductId, int qty)
        {
            var company = getCompany(companyId);
            company.ChangeQty(employeeId, storeId, saleId, menuId,terminalId, terminalAreaId, menuProductId, qty);
            _context.SaveChanges();
        }

        public bool RemoveSale(Guid companyId, Guid employeeId, Guid storeId, Guid saleId, Guid tableId, Guid terminalId, Guid terminalAreaId)
        {
            var company = getCompany(companyId);
            var result =  company.RemoveSale(employeeId, storeId, saleId, tableId, terminalId, terminalAreaId);
            _context.SaveChanges();
            return result;
        }

        public void ChangeCovers(Guid companyId, Guid storeId, Guid terminalAreaId, Guid terminalId, Guid saleId, int covers, Guid employeeId)
        {
            var company = getCompany(companyId);
            company.ChangeCovers(storeId, terminalAreaId, terminalId, saleId, covers, employeeId);
            _context.SaveChanges();
        }

        public IEnumerable<ICategory> GetCategories(Guid companyId, Guid storeId, Guid menuId)
        {
            var company = getCompany(companyId);
            return company.GetCategories(storeId, menuId);

        }

        public ICategory FetchCategory(Guid companyId, Guid storeId, Guid menuId, Guid catId)
        {
            var company = getCompany(companyId);
            return company.FetchCategory(storeId, menuId, catId);
        }

        public IMenuProduct[] GetCategoryMenuProducts(Guid companyId, Guid storeId, Guid menuId, Guid catId)
        {
            var company = getCompany(companyId);
            return company.GetCategoryMenuProducts(storeId, menuId, catId);
        }
        #endregion

        #region Payment
        public bool AddCashPayment(Guid companyId, Guid storeId, Guid saleId, decimal amount, Guid employeeId, Guid terminalAreaId, Guid terminalId)
        {
            var company = getCompany(companyId);
            var result =  company.AddCashPayment(storeId, saleId, amount, employeeId, terminalAreaId, terminalId);
            _context.SaveChanges();
            return result;
        }

        public bool AddEftposPayment(Guid companyId, Guid storeId, Guid saleId, decimal amount, Guid employeeId, Guid terminalAreaId, Guid terminalId)
        {
            var company = getCompany(companyId);
            var result =  company.AddEftposPayment(storeId, saleId, amount, employeeId, terminalAreaId, terminalId);
            _context.SaveChanges();
            return result;
        }

        public bool RemovePayment(Guid companyId, Guid storeId, Guid saleId, Guid paymentId, Guid employeeId, Guid terminalAreaId, Guid terminalId)
        {
            var company = getCompany(companyId);
            var result =  company.RemovePayment(storeId, saleId, paymentId, employeeId, terminalAreaId, terminalId);
            _context.SaveChanges();
            return result;
        } 
        #endregion

        #region Table
        public ISale MoveSaleFromTable(Guid companyId, Guid storeId, Guid terminalAreaId, Guid tableAreaId, Guid terminalId, Guid tableId)
        {
            var company = getCompany(companyId);
            var sale =  company.MoveSaleFromTable(storeId, terminalAreaId, tableAreaId, terminalId, tableId);
            _context.SaveChanges();
            return sale;

        }
        public void MoveSaleToTable(Guid companyId, Guid storeId, Guid terminalAreaId, Guid tableAreaId, Guid terminalId, Guid tableId, Guid saleId)
        {
            var company = getCompany(companyId);
            company.MoveSaleToTable(storeId, terminalAreaId, tableAreaId, terminalId, tableId, saleId);
            _context.SaveChanges();
        }

        public ITable GetTable(Guid companyId, Guid storeId, Guid tableAreaId, Guid tableId)
        {
            var company = getCompany(companyId);
            return company.GetTable(storeId, tableAreaId, tableId) as ITable;
        }

        public IEnumerable<IArea> GetAreasOFStore(Guid companyId, Guid storeId)
        {
            var company = getCompany(companyId);
            return company.GetAreasOFStore(storeId);
        }

        public IEnumerable<ITable> GetTablesInArea(Guid companyId, Guid storeId, Guid areaId)
        {
            var company = getCompany(companyId);
            return company.GetTablesInArea(storeId, areaId);
        }

        #endregion

        #region Product
        public IProductDescription AddProduct(Guid companyId, Guid storeId, Guid menuId, Guid categoryId, string description, decimal basePrice, bool gstFree)
        {
            var company = getCompany(companyId);
            var product =  company.AddProduct(storeId, menuId, categoryId, description, basePrice, gstFree);
            _context.SaveChanges();
            return product;
        }

        public IMenuProduct AddProductToMenu(Guid companyId, Guid storeId, Guid menuId, Guid categoryId, Guid productDescriptionId)
        {
            var company = getCompany(companyId);
            var menuProduct = company.AddProductToMenu(storeId, menuId, categoryId, productDescriptionId);
            _context.SaveChanges();
            return menuProduct;
        }

        public void RemoveProductFromMenu(Guid companyId, Guid storeId, Guid menuId, Guid menuProductId)
        {
            var company = getCompany(companyId);
            company.RemoveProductFromMenu(storeId, menuId, menuProductId);
        }

        #endregion

        #region Employee
        public IEmployee AddEmployee(Guid companyId, string firstName, string lastName, string password, IEnumerable<IPermission> permissions)
        {
            var company = getCompany(companyId);
            var employee = company.AddEmployee(firstName, lastName, password, permissions as IEnumerable<Permission>);
            _context.SaveChanges();
            return employee;
        }

        public void RemoveEmployee(Guid companyId, Guid employeeId)
        {
            var company = getCompany(companyId);
            company.RemoveEmployee(employeeId);
            _context.SaveChanges();
        }

        public void EditPermissions(Guid companyId, Guid storeId, Guid employeeId, IEnumerable<IPermission> permissions)
        {
            var company = getCompany(companyId);
            company.EditPermissions(storeId, employeeId, permissions as IEnumerable<Permission>);
            _context.SaveChanges();
        }

        public IEmployee GetEmployee(Guid companyId, Guid employeeId)
        {
            var company = getCompany(companyId);
            return company.GetEmployee(employeeId) as IEmployee;
        }

        public IEnumerable<IEmployee> GetEmployees(Guid companyId, Guid storeId)
        {
            var company = getCompany(companyId);
            return company.GetEmployees(storeId);
        }

        public bool AuthenticateEmployee(Guid companyId, Guid employeeId, string password)
        {
            var company = getCompany(companyId);
            return company.AuthenticateEmployee(employeeId, password);
        }

        public IEmployee CurrentLoggedInEmployee(Guid companyId)
        {  
            var company = getCompany(companyId);
            return company.CurrentLoggedInEmployee;
        }
                

        #endregion

        #region TableState
        public void OpenTable(Guid companyId, Guid storeId, Guid tableAreaId, Guid tableId)
        {
            var company = getCompany(companyId);
            company.OpenTable(storeId, tableAreaId, tableId);
            _context.SaveChanges();
        }
        public void CloseTable(Guid companyId, Guid storeId, Guid tableAreaId, Guid tableId)
        {
            var company = getCompany(companyId);
            company.CloseTable(storeId, tableAreaId, tableId);
            _context.SaveChanges();
        }
        #endregion

        private Company getCompany(Guid companyId)
        {
            return _context.Companies.First(c => c.Id.Equals(companyId));
        }

        public ITerminal GetTerminal(Guid terminalId)
        {
            var terminal = _context.Terminals.FirstOrDefault(t => t.Id.Equals(terminalId));
            return terminal as ITerminal;
        }

        public ISale GetSale(Guid companyId, Guid storeId, Guid terminalId, Guid terminlaAreaId, Guid saleId)
        {
            var company = getCompany(companyId);
            return company.GetSale(storeId, terminalId, terminlaAreaId, saleId);
        }

        public IArea GetTerminalArea(Guid terminalId)
        {
            var terminal = _context.Terminals.FirstOrDefault(t => t.Id.Equals(terminalId));
            if (terminal == null)
            {
                throw new Exception("Terminal could not be found");
            }
            else
                return terminal.Area as IArea;
        }

        #region Context

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion
    }
}
