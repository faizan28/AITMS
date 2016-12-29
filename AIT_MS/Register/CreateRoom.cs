using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIT_MS.App_Code;
namespace AIT_MS.Register
{
    public partial class CreateRoom : Form
    {
        clsRegister objRegister = new clsRegister();
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "")
            {


                if (objRegister.Addroom(cboxDeptName.SelectedValue.ToString(), txtRoomNo.Text, txtRoomDesc.Text) == true)
                {

                    this.Hide();
                    //reopen previous page of the  application after completion
                }
            }
            else 
            {
                lblEnterRoomNo.Visible = true;
            }
            
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            lblEnterRoomNo.Visible = false;
            BindComboBoxDept();
        }
        public void BindComboBoxDept()
        {
            DataTable dt = new DataTable();
            
            dt = objRegister.SelecAlltDept();
            cboxDeptName.DisplayMember = "d_name";
            cboxDeptName.ValueMember = "d_id";
            cboxDeptName.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            lblEnterRoomNo.Visible = false;
        }
    }
}
