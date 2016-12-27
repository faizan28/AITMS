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
    }
}
