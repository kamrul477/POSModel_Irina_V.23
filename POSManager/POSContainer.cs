using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Winforms.Configuration;
using POSApplications.Tasks;
using MVCSharp.Winforms;
using POSApplications;

namespace POSManager
{
    [WinformsView(typeof(POSContainerTask), POSContainerTask.POSContainer, IsMdiParent = true)]
    public partial class POSContainer : WinFormView, IPOSConainer
    {
        public POSContainer()
        {
            InitializeComponent();
            this.Width = SystemInformation.PrimaryMonitorSize.Width;
            this.Height = SystemInformation.PrimaryMonitorSize.Height;
            MDIManager.MDIParent = this;
            //(Controller as POSContainerController).ActivateLoginView();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            //MDIManager.MDIParent = this;
           (Controller as POSContainerController).ActivateLoginView();
        }

        public void UpdateView(){}
    }
}
