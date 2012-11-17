using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSApplications.Tasks;
using MVCSharp.Core.Configuration.Tasks;

namespace POSApplications
{
    public class POSContainerTask: POSBaseTask
    {
        [InteractionPoint(typeof(POSContainerController), IsCommonTarget = true)]
        public const string POSContainer = "POSContainer";

        public override void OnStart(object param)
        {
            Navigator.ActivateView(POSContainer);           
        }

        public void ActivateLoginView() 
        {
            this.TasksManager.StartTask(typeof(LoginTask));
        }
    }
}
