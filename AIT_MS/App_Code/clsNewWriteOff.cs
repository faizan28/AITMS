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
    }
}
