using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace AIT_MS.App_Code
{
    class clsCreateNewUser
    {
        DAL objDAL = new DAL();
        public void createuser(string username,string password)
        {
            string q = "insert into userlogin values('"+username+"','"+password+"')";
            objDAL.ExecuteQuery(q);
        }
        public DataTable getallusers()
        {
            string q = "select * from userlogin";
            return objDAL.GetAll(q);
        }
        public Boolean updateuser(string oldid, string username,string password)
        {
            string query = "update userlogin set u_name='" + username.ToString() + "',u_pass='"+password+"' where u_id='" + oldid.ToString() + "'";
            return objDAL.ExecuteQuery(query);

        }
        public Boolean deleteuser(string oldid)
        {
            string query = "delete from userlogin where u_id=" + oldid;
            return objDAL.ExecuteQuery(query);
        }
    }
}
