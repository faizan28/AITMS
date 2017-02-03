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


namespace AIT_MS.Issue
{
    public partial class FormIssue : Form
    {
        public FormIssue()
        {
            InitializeComponent();
        }
        clsIssue objclsIssue = new clsIssue();
        private void FormIssue_Load(object sender, EventArgs e)
        {
            bindItem();
        }
        private void bindItem()
        {
            DataTable dt = new DataTable();

            dt = objclsIssue.loadItem();
            comboBoxItemName.DisplayMember = "i_name";
            comboBoxItemName.ValueMember = "i_id";
            comboBoxItemName.DataSource = dt;
        }
    }
}
