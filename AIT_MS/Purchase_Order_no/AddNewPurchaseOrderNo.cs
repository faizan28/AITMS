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

namespace AIT_MS.Purchase_Order_no
{
    public partial class AddNewPurchaseOrderNo : Form
    {
        public AddNewPurchaseOrderNo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewPurchaseOrderNo_Load(object sender, EventArgs e)
        {
            //fill that combo box with drop down style
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                clsCreateNewPo_no objclsCreateNewPo_no = new clsCreateNewPo_no();
            
                objclsCreateNewPo_no.insertnewpono(cmbPurchaseOrderNo.Text);
                this.Hide();
           
        }
    }
}
