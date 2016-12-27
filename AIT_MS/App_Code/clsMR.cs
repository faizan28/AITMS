using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace AIT_MS.App_Code
{
    class clsMR
    {
        DAL objDAl = new DAL();
        public DataTable getallmr()
        {
            string query = "select * from mr"; 
            return objDAl.GetAll(query);
        }
        public DataTable getallmrid(int id)
        {
            string query = "select * from mr where mr_no ="+id;
            return objDAl.GetAll(query);
        }
    }
}
