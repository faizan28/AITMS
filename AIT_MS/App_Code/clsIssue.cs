using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace AIT_MS.App_Code
{
    class clsIssue
    {
        DAL objDAL = new DAL();
        public DataTable loadItem()
        {
            string query = "select i_id,i_name from item_a";
            return objDAL.GetAll(query);
        }
    }
}
