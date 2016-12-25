using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace AIT_MS
{
    class clsLogin
    {
        DAL objDAL = new DAL();
        public int UserLogin(string usrname,string Pwd)
        {
            string query = "select * from userlogin where u_name='" + usrname + "' and u_pass='" + Pwd + "'";
            DataTable dt = new DataTable();
            int id=objDAL.ExecuteScalar(query);
            return id;
 
        }
        public int AdminLogin(string usrname, string Pwd)
        {
            string query = "select * from adminlogin where a_name='" + usrname + "' and a_pass='" + Pwd + "'";
            DataTable dt = new DataTable();
            int id = objDAL.ExecuteScalar(query);
            return id;

        }




    }
}
