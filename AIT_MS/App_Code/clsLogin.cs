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

        public bool UpdatePwd(string user_id, string newpwd)
        {
            string query;
            if (Properties.Settings.Default["Role"].ToString() == "1")
            {
                query = "UPDATE adminlogin SET a_pass= '" + newpwd + "' WHERE a_id = '" + user_id + "'"; 
            }
            else
            {
                 query = "UPDATE userlogin SET u_pass= '" + newpwd + "' WHERE u_id = '" + user_id + "'";
            }
                DAL objDAL = new DAL();
                return objDAL.ExecuteQuery(query);
            
        }

        public int CheckUserPwd(string userId,string Pwd)
        {
            
            string query;
            if (Properties.Settings.Default["Role"].ToString() == "1")
            {
                query = "select * from adminlogin where a_id='" + userId + "' and a_pass='" + Pwd + "'";
            }
            else
            {
                query = "select * from userlogin where u_id='" + userId + "' and u_pass='" + Pwd + "'";
            }
            int id = objDAL.ExecuteScalar(query);
            return id;
        }



    }
}
