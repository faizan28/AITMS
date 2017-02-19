using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIT_MS.Register;
using AIT_MS.App_Code;
namespace AIT_MS
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addmasterhead objAddMasterHead = new addmasterhead();
            objAddMasterHead.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addhead objAddHead = new addhead();
            objAddHead.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItem objAddItem = new AddItem();
            objAddItem.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateStaff objCreateStaff = new CreateStaff();
            objCreateStaff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateDept objCreateDept = new CreateDept();
            objCreateDept.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateRoom objCreateRoom = new CreateRoom();
            objCreateRoom.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateCub objCreateCub = new CreateCub();
            objCreateCub.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.Show();
            this.Hide();
        }

        private void register_Load(object sender, EventArgs e)
        {
          
                
           



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void itemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadItem();
        }

        private void loadItem()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallitems();
            itemsGridView.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadStaff();
        }

        private void loadStaff()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallstaff();
            StaffGridView.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadHeadMaster();
        }
        private void loadHeadMaster()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();

            dt = obj.loadmhheadnames();
            HeadGridView.DataSource = dt;
        }

       



        private void btnViewDept_Click(object sender, EventArgs e)
        {
            lbl.Text = "All Departments";
            GetAllDepartments();
        }

        private void GetAllDepartments()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();

            dt = obj.SelecAlltDept();
            DeptRoomGrid.DataSource = dt;
        }

        private void GetAllHead_MasrerHead()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();

            dt = obj.getallHeadAndMasterHead();
            HeadGridView.DataSource = dt;

           
        }

        //private void btnViewAll_Click(object sender, EventArgs e)
        //{
        //    GetAllDept_room_cubical();
        //}

        //private void GetAllDept_room_cubical()
        //{
        //    clsRegister obj = new clsRegister();
        //    DataTable dt = new DataTable();
        //    dt = obj.
        //    DeptRoomGrid.DataSource = dt;
        //}

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            GetAllRooms();
        }

        private void GetAllRooms()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallRoom();
            DeptRoomGrid.DataSource = dt;
        }

        private void GetAllCubical()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallCubical_room();
            DeptRoomGrid.DataSource = dt;
        }

        private void btnViewCubical_Click(object sender, EventArgs e)
        {
            GetAllCubical();
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            GetAllHead_MasrerHead();
        }








    }
}
