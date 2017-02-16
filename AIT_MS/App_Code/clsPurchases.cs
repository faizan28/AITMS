using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AIT_MS.App_Code;
using DataAccess;

namespace AIT_MS.App_Code
{
    class clsPurchases
    {
        public DataTable loadItems(string hId)
        {
            DAL objDAl = new DAL();
            
            string query = "select * from item_a where h_id='" + hId + "'";

            return objDAl.GetAll(query);

        }
    }
}
