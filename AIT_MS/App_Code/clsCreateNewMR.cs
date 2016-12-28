using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;


namespace AIT_MS.App_Code
{
    class clsCreateNewMR
    {
        DAL objDAL = new DAL();
        public void createNewMRno(string mrno)
        {
            string query = "insert into mr values('"+mrno+"')";
            objDAL.ExecuteQuery(query);
        }
    }
}
