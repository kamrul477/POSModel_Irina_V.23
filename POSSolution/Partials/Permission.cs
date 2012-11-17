using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class Permission : IPermission
    {
        private Permission() { }

        public Permission(string description, string code)
        {
            Description = description;
            Code = code;
        }
        
        string IPermission.code
        {
            get { return Code; }
        }

        Guid IPermission.Id
        {
            get { return Id; }
        }

        string IPermission.Description
        {
            get { return Description; }
        }
    }
}
