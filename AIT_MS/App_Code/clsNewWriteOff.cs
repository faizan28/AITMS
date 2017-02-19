using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace AIT_MS.App_Code
{
    class clsNewWriteOff
    {
        public DataTable GetAllRoomIssues(string RoomId)
        {
            DAL objDAl = new DAL();

            string query = "select issue_to_room_a.isr_id,issue_to_room_a.i_id,issue_to_room_a.r_id,item_a.i_name from issue_to_room_a join item_a on issue_to_room_a.i_id=item_a.i_id where r_id='" + RoomId + "'";
            return objDAl.GetAll(query);

        }
        public DataTable GetAllStaffIssues(string StaffId)
        {
            DAL objDAl = new DAL();

            string query = "select issue_to_staff_a.iss_id,issue_to_staff_a.i_id,issue_to_staff_a.s_id,item_a.i_name from issue_to_staff_a join item_a on issue_to_staff_a.i_id=item_a.i_id where s_id='" + StaffId + "'";

            return objDAl.GetAll(query);

        }
        public DataTable GetAllRoomIssuesGrid(string RoomId)
        {
            DAL objDAl = new DAL();

            string query = "select issue_to_room_a.isr_doi,issue_to_room_a.mr_no,issue_to_room_a.isr_id,dept.d_name,room_info.r_name,master_heada.mh_name,heada.h_name,item_a.i_name,issue_to_room_a.isr_quantity,issue_to_room_a.remarks,userlogin.u_name from issue_to_room_a join room_info on issue_to_room_a.r_id=room_info.r_id join dept on room_info.d_id=dept.d_id join userlogin on issue_to_room_a.u_id=userlogin.u_id join item_a on issue_to_room_a.i_id=item_a.i_id join heada on item_a.h_id=heada.h_id join master_heada on heada.mh_id=master_heada.mh_id where issue_to_room_a.r_id='"+RoomId+"'";
            return objDAl.GetAll(query);

        }
        public DataTable GetAllStaffIssuesGrid(string StaffId)
        {
            DAL objDAl = new DAL();

            string query = "SELECT issue_to_staff_a.isr_doi,issue_to_staff_a.mr_no,issue_to_staff_a.iss_id,dept.d_name,room_info.r_name,cub.c_name,staff.s_fname,master_heada.mh_name,heada.h_name,item_a.i_name, issue_to_staff_a.iss_quantity, issue_to_staff_a.remarks, userlogin.u_name FROM issue_to_staff_a JOIN staff on issue_to_staff_a.s_id=staff.s_id JOIN cub ON staff.c_id=cub.c_id JOIN room_info ON cub.r_id=room_info.r_id JOIN dept ON room_info.d_id=dept.d_id JOIN userlogin ON issue_to_staff_a.u_id=userlogin.u_id JOIN item_a ON issue_to_staff_a.i_id=item_a.i_id JOIN heada ON item_a.h_id=heada.h_id JOIN master_heada ON heada.mh_id=master_heada.mh_id WHERE issue_to_staff_a.s_id='"+StaffId+"'";

            return objDAl.GetAll(query);

        }
       
        public DataTable GetAllDeptRoomIssuesGrid(string DeptId)
        {
            DAL objDAl = new DAL();

            string query = "select issue_to_room_a.isr_doi,issue_to_room_a.mr_no,issue_to_room_a.isr_id,dept.d_name,room_info.r_name,master_heada.mh_name,heada.h_name,item_a.i_name,issue_to_room_a.isr_quantity,issue_to_room_a.remarks,userlogin.u_name from issue_to_room_a join room_info on issue_to_room_a.r_id=room_info.r_id join dept on room_info.d_id=dept.d_id join userlogin on issue_to_room_a.u_id=userlogin.u_id join item_a on issue_to_room_a.i_id=item_a.i_id join heada on item_a.h_id=heada.h_id join master_heada on heada.mh_id=master_heada.mh_id where dept.d_id='" + DeptId + "'";

            return objDAl.GetAll(query);

        }
        public DataTable GetAllDeptStaffIssuesGrid(string deptId)
        {
            DAL objDAl = new DAL();

            string query = "SELECT issue_to_staff_a.isr_doi,issue_to_staff_a.mr_no,issue_to_staff_a.iss_id,dept.d_name,room_info.r_name,cub.c_name,staff.s_fname,master_heada.mh_name,heada.h_name,item_a.i_name, issue_to_staff_a.iss_quantity, issue_to_staff_a.remarks, userlogin.u_name FROM issue_to_staff_a JOIN staff on issue_to_staff_a.s_id=staff.s_id JOIN cub ON staff.c_id=cub.c_id JOIN room_info ON cub.r_id=room_info.r_id JOIN dept ON room_info.d_id=dept.d_id JOIN userlogin ON issue_to_staff_a.u_id=userlogin.u_id JOIN item_a ON issue_to_staff_a.i_id=item_a.i_id JOIN heada ON item_a.h_id=heada.h_id JOIN master_heada ON heada.mh_id=master_heada.mh_id WHERE dept.d_id='" + deptId + "'";

            return objDAl.GetAll(query);

        }
        public DataTable GetAllRoomStaffIssuesGrid(string roomId)
        {
            DAL objDAl = new DAL();

            string query = "SELECT issue_to_staff_a.isr_doi,issue_to_staff_a.mr_no,issue_to_staff_a.iss_id,dept.d_name,room_info.r_name,cub.c_name,staff.s_fname,master_heada.mh_name,heada.h_name,item_a.i_name, issue_to_staff_a.iss_quantity, issue_to_staff_a.remarks, userlogin.u_name FROM issue_to_staff_a JOIN staff on issue_to_staff_a.s_id=staff.s_id JOIN cub ON staff.c_id=cub.c_id JOIN room_info ON cub.r_id=room_info.r_id JOIN dept ON room_info.d_id=dept.d_id JOIN userlogin ON issue_to_staff_a.u_id=userlogin.u_id JOIN item_a ON issue_to_staff_a.i_id=item_a.i_id JOIN heada ON item_a.h_id=heada.h_id JOIN master_heada ON heada.mh_id=master_heada.mh_id WHERE room_info.r_id='" + roomId + "'";

            return objDAl.GetAll(query);

        }
        public DataTable GetAllCubicalStaffIssuesGrid(string cubId)
        {
            DAL objDAl = new DAL();

            string query = "SELECT issue_to_staff_a.isr_doi,issue_to_staff_a.mr_no,issue_to_staff_a.iss_id,dept.d_name,room_info.r_name,cub.c_name,staff.s_fname,master_heada.mh_name,heada.h_name,item_a.i_name, issue_to_staff_a.iss_quantity, issue_to_staff_a.remarks, userlogin.u_name FROM issue_to_staff_a JOIN staff on issue_to_staff_a.s_id=staff.s_id JOIN cub ON staff.c_id=cub.c_id JOIN room_info ON cub.r_id=room_info.r_id JOIN dept ON room_info.d_id=dept.d_id JOIN userlogin ON issue_to_staff_a.u_id=userlogin.u_id JOIN item_a ON issue_to_staff_a.i_id=item_a.i_id JOIN heada ON item_a.h_id=heada.h_id JOIN master_heada ON heada.mh_id=master_heada.mh_id WHERE cub.c_id='" + cubId + "'";

            return objDAl.GetAll(query);

        }
    }
}
