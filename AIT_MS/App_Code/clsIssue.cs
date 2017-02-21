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
        public void issueToRoom(int i_id,int qty,int rid,string isr_doi,int mr_no,string remarks,int u_id)
        {
            string q = "insert into issue_to_room_a values("+i_id+","+qty+","+rid+",CONVERT(datetime,'"+isr_doi+"',103),"+mr_no+",'"+remarks+"',"+u_id+")";
            objDAL.ExecuteQuery(q);
        }
        public void decreasestock(int i_id, int qty)
        {
            string q = "update item_a set i_stock=i_stock-" + qty + " where i_id=" + i_id;
            objDAL.ExecuteQuery(q);
        }
        public void issueToStaff(int i_id, int qty, int rid, string isr_doi, int mr_no, string remarks, int u_id)
        {
            string q = "insert into issue_to_staff_a values(" + i_id + "," + qty + "," + rid + ",CONVERT(datetime,'" + isr_doi + "',103)," + mr_no + ",'" + remarks + "'," + u_id + ")";
            objDAL.ExecuteQuery(q);
        }
        public DataTable GetAllMr()
        {
            string query = "select * from mr";
            return objDAL.GetAll(query);
        }
       

    }
}
