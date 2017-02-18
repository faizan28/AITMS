using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Globalization;
using System.Windows.Forms;


namespace AIT_MS.App_Code
{
    class clsAddNewPurchase
    {
        DAL objDAL = new DAL();
        DateTimeFormatInfo dateinfo = new DateTimeFormatInfo();
       
        public void addnewentry(int i_id, string i_name, string po_no, string dop, string doe, string s_name, int qty, double t_price, string remarks, int u_id)
        {
            
           string q = "insert into purchase_a values(" + i_id + ",'" + po_no + "',CONVERT(datetime,'" + dop + "',103),"+"CONVERT(datetime,'" + doe + "',103),'" + s_name + "'," + qty + "," + t_price + ",'" + remarks + "'," + u_id + ")";
            objDAL.ExecuteQuery(q);
        }
        public void increasestock(int i_id, int qty)
        {
            string q = "update item_a set i_stock=i_stock+"+qty+" where i_id="+i_id;
            objDAL.ExecuteQuery(q);
        }
        public DataTable GetAllPO()
        {
            DAL objDAl = new DAL();

            string query = "select * from  purchaseo_no";

            return objDAl.GetAll(query);

        }
    }
}
