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
    public partial class CreateCub : Form
    {
        clsRegister objRegister = new clsRegister();
        public CreateCub()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void BindComboBoxRoom()
        {
            DataTable dt = new DataTable();
            dt = objRegister.SelectDeptRoom(cboxDept.SelectedValue.ToString());
            cboxRoomNo.DisplayMember = "r_name";
            cboxRoomNo.ValueMember = "r_id";
            cboxRoomNo.DataSource = dt;
        }

        private void CreateCub_Load(object sender, EventArgs e)
        {
            
            BindComboBoxDept();
            cboxRoomNo.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createcubButton_Click(object sender, EventArgs e)
        {
            if (objRegister.AddCubical(cboxRoomNo.SelectedValue.ToString(), txtCubicalName.Text) == true)
            {
                MessageBox.Show("Successfull");
                this.Hide();
            }
        }
        public void BindComboBoxDept()
        {
            DataTable dt = new DataTable();

            dt = objRegister.SelecAlltDept();
            DataRow row = dt.NewRow();
            row["d_name"] = "Please select";
            dt.Rows.InsertAt(row, 0);
            cboxDept.DisplayMember = "d_name";
            cboxDept.ValueMember = "d_id";
            cboxDept.DataSource = dt;
        }

        private void cboxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxRoomNo.Enabled = true;
            BindComboBoxRoom();
        }
    }
}
