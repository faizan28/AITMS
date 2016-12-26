using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace AIT_MS.App_Code
{
    class clsRegister
    {
        DAL objDAl = new DAL();
        public Boolean createMasterHead(string masterHeadName)
        {
            string query = "insert into master_heada values('"+masterHeadName.ToString()+"')";
            return objDAl.ExecuteQuery(query);
        }
        public DataTable loadheadnames()
        {
            string query = "select * from master_heada";
            DataTable dt = new DataTable();
            dt = objDAl.GetAll(query);
            return dt;
        }
        public Boolean createHead(string headName)
        {
            string query = "insert into heada values('" + headName + "')" ;
            return objDAl.ExecuteQuery(query);
        }
    }
}
