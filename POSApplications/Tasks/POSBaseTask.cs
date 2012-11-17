using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core.Tasks;
using POSModel;
using System.Configuration;
using MVCSharp.Core.Configuration.Tasks;
using POSApplications.Controllers;


namespace POSApplications.Tasks
{
    public class POSBaseTask: TaskBase    
    {
        POSSystem _system = POSSystem.Instance;

        public POSSystem System
        {
            get { return _system; }
        }

        private Guid terminalId
        {
            get
            {
                return new Guid(ConfigurationManager.AppSettings["1"]);
            }
        }

        public ITerminal Terminal
        {
            get
            {
                return _system.GetTerminal(terminalId);
            }
        }

        //public ITerminal Terminal
        //{
        //    get
        //    {
        //        //using (POSSystem _system = POSSystem.Instance)
        //        //{
        //            return _system.GetTerminal(terminalId);
        //        //}
        //    }
        //}

        //public ITerminal GetTerminal(POSSystem _system)
        //{
        //    return _system.GetTerminal(terminalId);
        //}

        public ICompany Company
        {
            get
            {
                return Terminal.Company;
            }
        }

        public IStore Store
        {
            get
            {
                return Terminal.Store;
            }
        }

        public IArea TerminalArea
        {
            get
            {
                return Terminal.Area;
            }
        }

        public IMenu CurrentMenu { get; set; }

        public override void OnStart(object param)
        {            
            CurrentMenu = Terminal.Store.Menus.First();
            base.OnStart(param);
        }     
    }
}
