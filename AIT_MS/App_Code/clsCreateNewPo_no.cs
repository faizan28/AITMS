using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace AIT_MS.App_Code
{
    class clsCreateNewPo_no
    {
        DAL objDAL = new DAL();
        public void insertnewpono(string po_no)
        {
            string q = "insert into purchaseo_no values('"+po_no+"')";
            objDAL.ExecuteQuery(q);
        }
    }
}
