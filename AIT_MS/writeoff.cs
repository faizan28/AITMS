﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_MS
{
    public partial class writeoff : Form
    {
        public writeoff()
        {
            InitializeComponent();
        }

        private void btnNewWriteOff_Click(object sender, EventArgs e)
        {
            NewWirteOff objNewWriteOff = new NewWirteOff();
            objNewWriteOff.Show();
        }
    }
}
