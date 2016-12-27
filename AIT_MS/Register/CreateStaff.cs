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
    public partial class CreateStaff : Form
    {
        clsRegister objRegister = new clsRegister();
        public CreateStaff()
        {
            InitializeComponent();
        }

        private void CreateStaff_Load(object sender, EventArgs e)
        {
            BindComboBoxCub();
            BindComboBoxRoom();
            BindComboBoxDept();
        }
        public void BindComboBoxDept()
        {
            DataTable dt = new DataTable();

            dt = objRegister.SelecAlltDept();
            cboxDept.DisplayMember = "d_name";
            cboxDept.ValueMember = "d_id";
            cboxDept.DataSource = dt;
        }
        public void BindComboBoxRoom()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            dt1 = objRegister.SelecAllRoom();
            cboxRoom.DisplayMember = "r_name";
            cboxRoom.ValueMember = "r_id";
            cboxRoom.DataSource = dt1;
        }
        public void BindComboBoxCub()
        {
            DataTable dt2 = new DataTable();
            dt2 = objRegister.SelecAllCub();
            cboxCub.DisplayMember = "c_name";
            cboxCub.ValueMember = "c_id";
            cboxCub.DataSource = dt2;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (objRegister.AddNewStaff(cboxDept.SelectedValue.ToString(), cboxRoom.SelectedValue.ToString(), cboxCub.SelectedValue.ToString(), txtFrstname.Text, txtScndName.Text, txtPrsnlId.Text, txtRemarks.Text) == true)
            {
                MessageBox.Show("Successful");
                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
