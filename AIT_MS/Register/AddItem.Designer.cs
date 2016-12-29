namespace AIT_MS.Register
{
    partial class AddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richtxtBoxItemDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxH_ID = new System.Windows.Forms.ComboBox();
            this.comboBoxMH_ID = new System.Windows.Forms.ComboBox();
            this.txtboxItemStock = new System.Windows.Forms.TextBox();
            this.txtboxItemName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEnterItemName = new System.Windows.Forms.Label();
            this.lblEnterStock = new System.Windows.Forms.Label();
            this.lblSelectMH = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectMH);
            this.groupBox1.Controls.Add(this.lblEnterStock);
            this.groupBox1.Controls.Add(this.lblEnterItemName);
            this.groupBox1.Controls.Add(this.richtxtBoxItemDesc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxH_ID);
            this.groupBox1.Controls.Add(this.comboBoxMH_ID);
            this.groupBox1.Controls.Add(this.txtboxItemStock);
            this.groupBox1.Controls.Add(this.txtboxItemName);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richtxtBoxItemDesc
            // 
            this.richtxtBoxItemDesc.Location = new System.Drawing.Point(341, 235);
            this.richtxtBoxItemDesc.Name = "richtxtBoxItemDesc";
            this.richtxtBoxItemDesc.Size = new System.Drawing.Size(227, 96);
            this.richtxtBoxItemDesc.TabIndex = 11;
            this.richtxtBoxItemDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item Desc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Head";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Master Head";
            // 
            // comboBoxH_ID
            // 
            this.comboBoxH_ID.FormattingEnabled = true;
            this.comboBoxH_ID.Location = new System.Drawing.Point(341, 90);
            this.comboBoxH_ID.Name = "comboBoxH_ID";
            this.comboBoxH_ID.Size = new System.Drawing.Size(227, 21);
            this.comboBoxH_ID.TabIndex = 5;
            // 
            // comboBoxMH_ID
            // 
            this.comboBoxMH_ID.FormattingEnabled = true;
            this.comboBoxMH_ID.Location = new System.Drawing.Point(341, 44);
            this.comboBoxMH_ID.Name = "comboBoxMH_ID";
            this.comboBoxMH_ID.Size = new System.Drawing.Size(227, 21);
            this.comboBoxMH_ID.TabIndex = 4;
            this.comboBoxMH_ID.SelectedIndexChanged += new System.EventHandler(this.comboBoxMH_ID_SelectedIndexChanged);
            // 
            // txtboxItemStock
            // 
            this.txtboxItemStock.Location = new System.Drawing.Point(341, 173);
            this.txtboxItemStock.Name = "txtboxItemStock";
            this.txtboxItemStock.Size = new System.Drawing.Size(227, 20);
            this.txtboxItemStock.TabIndex = 2;
            this.txtboxItemStock.TextChanged += new System.EventHandler(this.txtboxItemStock_TextChanged);
            // 
            // txtboxItemName
            // 
            this.txtboxItemName.Location = new System.Drawing.Point(341, 131);
            this.txtboxItemName.Name = "txtboxItemName";
            this.txtboxItemName.Size = new System.Drawing.Size(227, 20);
            this.txtboxItemName.TabIndex = 1;
            this.txtboxItemName.TextChanged += new System.EventHandler(this.txtboxItemName_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(481, 416);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Create";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(592, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEnterItemName
            // 
            this.lblEnterItemName.AutoSize = true;
            this.lblEnterItemName.ForeColor = System.Drawing.Color.Red;
            this.lblEnterItemName.Location = new System.Drawing.Point(482, 154);
            this.lblEnterItemName.Name = "lblEnterItemName";
            this.lblEnterItemName.Size = new System.Drawing.Size(86, 13);
            this.lblEnterItemName.TabIndex = 12;
            this.lblEnterItemName.Text = "Enter Item Name";
            // 
            // lblEnterStock
            // 
            this.lblEnterStock.AutoSize = true;
            this.lblEnterStock.ForeColor = System.Drawing.Color.Red;
            this.lblEnterStock.Location = new System.Drawing.Point(505, 196);
            this.lblEnterStock.Name = "lblEnterStock";
            this.lblEnterStock.Size = new System.Drawing.Size(63, 13);
            this.lblEnterStock.TabIndex = 13;
            this.lblEnterStock.Text = "Enter Stock";
            // 
            // lblSelectMH
            // 
            this.lblSelectMH.AutoSize = true;
            this.lblSelectMH.ForeColor = System.Drawing.Color.Red;
            this.lblSelectMH.Location = new System.Drawing.Point(467, 68);
            this.lblSelectMH.Name = "lblSelectMH";
            this.lblSelectMH.Size = new System.Drawing.Size(101, 13);
            this.lblSelectMH.TabIndex = 14;
            this.lblSelectMH.Text = "Select Master Head";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 479);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richtxtBoxItemDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxH_ID;
        private System.Windows.Forms.ComboBox comboBoxMH_ID;
        private System.Windows.Forms.TextBox txtboxItemStock;
        private System.Windows.Forms.TextBox txtboxItemName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEnterStock;
        private System.Windows.Forms.Label lblEnterItemName;
        private System.Windows.Forms.Label lblSelectMH;
    }
}