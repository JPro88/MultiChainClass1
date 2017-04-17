using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.MultichainLib
{
    public class PermissionManager : ServiceBase
    {
        public PermissionManager(JsonRpcClient c):base(c)
        {

        }

        public string ListPermissions(string permission=null)
        {
            throw new NotImplementedException();
        }

        public string ListPermissions(string permission, string address)
        {
            throw new NotImplementedException();
        }

        public string Grant(string address, string permission)
        {
            throw new NotImplementedException();
        }

    }
}
