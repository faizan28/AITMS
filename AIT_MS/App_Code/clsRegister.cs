﻿using System;
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
        public DataTable loadheadnames()
        {
            string query = "select * from master_heada";
            DataTable dt = new DataTable();
            dt = objDAl.GetAll(query);
            return dt;
        }
        public Boolean createHead(string headName)
        {
            string query = "insert into heada values('" + headName + "')" ;
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
        public DataTable SelecAllCub()
        {
            string query = "Select * from cub";
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
   }
}
