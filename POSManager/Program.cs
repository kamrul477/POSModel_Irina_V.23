using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Core.Tasks;
using POSApplications.Tasks;
using MVCSharp.Winforms;
using POSApplications;
using POSApplication.Tasks;
using Controller;

namespace POSManager
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                TasksManager tasksManager = new TasksManager(WinformsViewsManager.GetDefaultConfig());
                tasksManager.StartTask(typeof(POSContainerTask));
                //tasksManager.StartTask(typeof(ProcessSaleTask));
                //tasksManager.StartTask(typeof(PaymentTask));
                //tasksManager.StartTask(typeof(DefineCoversTask));
                //tasksManager.StartTask(typeof(TableViewTask));
                Application.Run(Application.OpenForms[0]);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
