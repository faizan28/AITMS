using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace AIT_MS.App_Code
{
    class clsSearch
    {
        DAL objDAl = new DAL();
        public DataTable SelecAlltDept()
        {
            string query = "Select d_name As 'Department Name',d_desc As Discription from dept";
            return objDAl.GetAll(query);


        }
        public DataTable SelecAllRoom()
        {
            string query = "Select room_info.r_name AS 'Room Name',dept.d_name AS 'Department Name',room_info.r_desc AS 'Description' from room_info join dept on room_info.d_id=dept.d_id";
            return objDAl.GetAll(query);


        }
        public DataTable SelecAllCub()
        {
            string query = "Select cub.c_name AS 'Cubical Name',room_info.r_name AS 'Room Name' from cub join room_info on cub.r_id=room_info.r_id";
            return objDAl.GetAll(query);


        }
        public DataTable getallstaff()
        {
            string query = "Select staff.s_pid AS 'Personel ID',staff.s_fname AS 'First Name',staff.s_lname AS 'Last Name',cub.c_name AS 'Cubical',room_info.r_name AS 'Room',dept.d_name AS 'Department',staff.s_remarks AS 'Remarks' from Staff join cub on staff.c_id=cub.c_id join room_info on cub.r_id=room_info.r_id join dept on room_info.d_id=dept.d_id";
            DataTable dt = new DataTable();
            dt = objDAl.GetAll(query);
            return dt;


        }
        public DataTable getallitems()
        {
            string query = "select item_a.i_name AS 'Name',item_a.i_stock AS 'Stock',heada.h_name AS 'Head',master_heada.mh_name AS 'Master Head',item_a.i_desc AS 'Description' from item_a  join master_heada on item_a.mh_id=master_heada.mh_id join heada on item_a.h_id=heada.h_id";
            DataTable dt = new DataTable();
            dt = objDAl.GetAll(query);
            return dt;


        }
        public DataTable GetAllPurchases()
        {
            DAL objDAl = new DAL();

            string query = "select purchaseo_no.po_no AS 'PO Number',item_a.i_name AS 'Item Name',purchase_a.quantity AS 'Quantity',purchase_a.t_price AS 'Total Cost',purchase_a.dop AS 'Purchase Date',purchase_a.doe AS 'Entry Date',purchase_a.remarks AS 'Remarks',userlogin.u_name AS 'Username' from  purchase_a join item_a on purchase_a.i_id=item_a.i_id join purchaseo_no on purchase_a.po_id=purchaseo_no.po_id join userlogin on purchase_a.u_id=userlogin.u_id";

            return objDAl.GetAll(query);

        }
        public DataTable GetAllIssues_S()
        {
            string query = "select issue_to_staff_a.isr_doi AS 'Date',item_a.i_name AS 'Item Name',issue_to_staff_a.iss_quantity AS 'Quantity',staff.s_fname AS 'Staff Name',mr.mr_no AS 'MR No.',userlogin.u_name AS 'Username',issue_to_staff_a.remarks AS 'Remarks' from issue_to_staff_a join item_a on issue_to_staff_a.i_id=item_a.i_id join staff on issue_to_staff_a.s_id=staff.s_id join mr on issue_to_staff_a.mr_no=mr.mr_id join userlogin on issue_to_staff_a.u_id=userlogin.u_id";
            return objDAl.GetAll(query);
        }
        public DataTable GetAllIssues_R()
        {
            string query = "select issue_to_room_a.isr_doi AS 'Date',item_a.i_name AS 'Item Name',issue_to_room_a.isr_quantity AS 'Quantity',room_info.r_name AS 'Room',mr.mr_no AS 'MR No.',userlogin.u_name AS 'Username',issue_to_room_a.remarks AS 'Remarks' from issue_to_room_a join item_a on issue_to_room_a.i_id=item_a.i_id join room_info on issue_to_room_a.r_id=room_info.r_id join mr on issue_to_room_a.mr_no=mr.mr_id join userlogin on issue_to_room_a.u_id=userlogin.u_id";
            return objDAl.GetAll(query);
        }
    }
}
