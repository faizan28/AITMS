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
        public DataTable loadmhheadnames()
        {
            string query = "select mh_id,mh_name from master_heada";
            return objDAl.GetAll(query);
        }
        public DataTable loadheadnames(string mhId)
        {
            string query = "select h_id,h_name from heada where mh_id='"+mhId+"'";
           
            return objDAl.GetAll(query);
            
        }
        public Boolean createHead(string headName, int masterHeadName)
        {
            
            string query = "insert into heada values('" + headName + "','"+ masterHeadName +"')" ;
            
            return objDAl.ExecuteQuery(query);

        }
        public Boolean createItem(int mhID, int hID, string itemDESC, string iStock, string iName)
        {
            string query = "insert into item_a values('"+mhID+"','"+hID+"','"+itemDESC+"','"+iStock+"','"+iName+"')";
            return objDAl.ExecuteQuery(query);
        }


        public Boolean AddDept(string dname,string desc)
        {
            string query = "insert into dept (d_name,d_desc) values ('"+dname+"','"+desc+"');";
            return objDAl.ExecuteQuery(query);  

        }
        public DataTable SelecAlltDept()
        {
            string query = "Select * from dept";
            return objDAl.GetAll(query);

 
        }
        public DataTable SelecAllRoom()
        {
            string query = "Select * from room_info";
            return objDAl.GetAll(query);


        }
        public DataTable SelectDeptRoom(string deptId)
        {
            string query = "Select * from room_info where d_id='"+deptId+"'";
            return objDAl.GetAll(query);


        }
        public DataTable SelecAllCub()
        {
            string query = "Select * from cub";
            return objDAl.GetAll(query);


        }
        public DataTable SelectCub(string roomno)
        {
            string query = "Select * from cub where r_id='"+roomno+"'";
            return objDAl.GetAll(query);


        }
        public DataTable SelectSatff(string Cubno)
        {
            string query = "Select * from staff where c_id='" + Cubno + "'";
            return objDAl.GetAll(query);


        }
        public Boolean Addroom(string deptId, string roomNo,string roomDesc)
        {
            string query = "insert into room_info (r_name,d_id,r_desc) values ('" + roomNo + "','" + deptId + "','"+roomDesc+"');";
            return objDAl.ExecuteQuery(query);

        }
        public Boolean AddCubical(string roomNo, string cubicalName)
        {
            string query = "insert into cub (r_id,c_name) values ('" + roomNo + "','" + cubicalName + "');";
            return objDAl.ExecuteQuery(query);

        }
        public Boolean AddNewStaff(string deptID,string roomID,string cubID,string frstName,string lstName,string prsnlId,string remarks)
        {
            string query = "insert into staff (d_id,r_id,c_id,s_fname,s_lname,s_pid,s_remarks) values ('" + deptID + "','" + roomID + "','"+cubID+"','"+frstName+"','"+lstName+"','"+prsnlId+"','"+remarks+"');";
            return objDAl.ExecuteQuery(query);

        }
        
        public DataTable getallitems()
        {
            string query = "select item_a.i_desc,item_a.i_stock,item_a.i_name,master_heada.mh_name,heada.h_name from item_a  join master_heada on item_a.mh_id=master_heada.mh_id join heada on item_a.h_id=heada.h_id";
            DataTable dt = new DataTable();
            dt = objDAl.GetAll(query);
            return dt;
            

        }

        public DataTable getallstaff()
        {
            string query = "select item_a.i_desc,item_a.i_stock,item_a.i_name,master_heada.mh_name,heada.h_name from item_a  join master_heada on item_a.i_id=master_heada.mh_id join heada on item_a.i_id=heada.h_id";
            DataTable dt = new DataTable();
            dt = objDAl.GetAll(query);
            return dt;


        }

   }
}
