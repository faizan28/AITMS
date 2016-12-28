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
        public DataTable getallmrid(string id)
        {
            string query = "select * from mr where mr_id ='"+id+"'";
            return objDAl.GetAll(query);
        }
        public Boolean updatemr(string oldmr,string newmr)
        {
            string query = "update mr set mr_no='"+newmr.ToString()+"' where mr_id='"+oldmr.ToString()+"'";
            return objDAl.ExecuteQuery(query);
            
        }
        public Boolean deletemr(string mrid)
        {
            string query = "delete from mr where mr_id="+mrid;
            return objDAl.ExecuteQuery(query);
        }
    }
}
