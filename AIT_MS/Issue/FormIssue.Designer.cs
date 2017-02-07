namespace AIT_MS.Issue
{
    partial class FormIssue
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
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxMH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectMH = new System.Windows.Forms.Label();
            this.lblEnterItemName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxIssueTo = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cboxDept = new System.Windows.Forms.ComboBox();
            this.cboxRoomNo = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblCub = new System.Windows.Forms.Label();
            this.cboxCub = new System.Windows.Forms.ComboBox();
            this.lblSatff = new System.Windows.Forms.Label();
            this.cboxStaff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxItem
            // 
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(128, 107);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(121, 21);
            this.cboxItem.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(128, 153);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(121, 20);
            this.txtQty.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qty";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(291, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Master Head";
            // 
            // cboxMH
            // 
            this.cboxMH.FormattingEnabled = true;
            this.cboxMH.Location = new System.Drawing.Point(128, 19);
            this.cboxMH.Name = "cboxMH";
            this.cboxMH.Size = new System.Drawing.Size(121, 21);
            this.cboxMH.TabIndex = 7;
            this.cboxMH.SelectedIndexChanged += new System.EventHandler(this.cboxMH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Head";
            // 
            // cboxH
            // 
            this.cboxH.FormattingEnabled = true;
            this.cboxH.Location = new System.Drawing.Point(128, 64);
            this.cboxH.Name = "cboxH";
            this.cboxH.Size = new System.Drawing.Size(121, 21);
            this.cboxH.TabIndex = 9;
            this.cboxH.SelectedIndexChanged += new System.EventHandler(this.cboxH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // lblSelectMH
            // 
            this.lblSelectMH.AutoSize = true;
            this.lblSelectMH.ForeColor = System.Drawing.Color.Red;
            this.lblSelectMH.Location = new System.Drawing.Point(148, 43);
            this.lblSelectMH.Name = "lblSelectMH";
            this.lblSelectMH.Size = new System.Drawing.Size(101, 13);
            this.lblSelectMH.TabIndex = 23;
            this.lblSelectMH.Text = "Select Master Head";
            // 
            // lblEnterItemName
            // 
            this.lblEnterItemName.AutoSize = true;
            this.lblEnterItemName.ForeColor = System.Drawing.Color.Red;
            this.lblEnterItemName.Location = new System.Drawing.Point(163, 131);
            this.lblEnterItemName.Name = "lblEnterItemName";
            this.lblEnterItemName.Size = new System.Drawing.Size(86, 13);
            this.lblEnterItemName.TabIndex = 24;
            this.lblEnterItemName.Text = "Enter Item Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxIssueTo);
            this.groupBox1.Location = new System.Drawing.Point(432, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue To";
            // 
            // cboxIssueTo
            // 
            this.cboxIssueTo.FormattingEnabled = true;
            this.cboxIssueTo.Location = new System.Drawing.Point(6, 15);
            this.cboxIssueTo.Name = "cboxIssueTo";
            this.cboxIssueTo.Size = new System.Drawing.Size(188, 21);
            this.cboxIssueTo.TabIndex = 26;
            this.cboxIssueTo.SelectedIndexChanged += new System.EventHandler(this.cboxIssueTo_SelectedIndexChanged);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(429, 88);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "Department";
            // 
            // cboxDept
            // 
            this.cboxDept.FormattingEnabled = true;
            this.cboxDept.Location = new System.Drawing.Point(505, 85);
            this.cboxDept.Name = "cboxDept";
            this.cboxDept.Size = new System.Drawing.Size(121, 21);
            this.cboxDept.TabIndex = 28;
            this.cboxDept.SelectedIndexChanged += new System.EventHandler(this.cboxDept_SelectedIndexChanged);
            // 
            // cboxRoomNo
            // 
            this.cboxRoomNo.FormattingEnabled = true;
            this.cboxRoomNo.Location = new System.Drawing.Point(505, 112);
            this.cboxRoomNo.Name = "cboxRoomNo";
            this.cboxRoomNo.Size = new System.Drawing.Size(121, 21);
            this.cboxRoomNo.TabIndex = 27;
            this.cboxRoomNo.SelectedIndexChanged += new System.EventHandler(this.cboxRoomNo_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(429, 115);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(52, 13);
            this.lblRoom.TabIndex = 26;
            this.lblRoom.Text = "Room No";
            // 
            // lblCub
            // 
            this.lblCub.AutoSize = true;
            this.lblCub.Location = new System.Drawing.Point(429, 142);
            this.lblCub.Name = "lblCub";
            this.lblCub.Size = new System.Drawing.Size(59, 13);
            this.lblCub.TabIndex = 31;
            this.lblCub.Text = "Cubicle No";
            // 
            // cboxCub
            // 
            this.cboxCub.FormattingEnabled = true;
            this.cboxCub.Location = new System.Drawing.Point(505, 139);
            this.cboxCub.Name = "cboxCub";
            this.cboxCub.Size = new System.Drawing.Size(121, 21);
            this.cboxCub.TabIndex = 30;
            this.cboxCub.SelectedIndexChanged += new System.EventHandler(this.cboxCub_SelectedIndexChanged);
            // 
            // lblSatff
            // 
            this.lblSatff.AutoSize = true;
            this.lblSatff.Location = new System.Drawing.Point(429, 170);
            this.lblSatff.Name = "lblSatff";
            this.lblSatff.Size = new System.Drawing.Size(29, 13);
            this.lblSatff.TabIndex = 33;
            this.lblSatff.Text = "Staff";
            // 
            // cboxStaff
            // 
            this.cboxStaff.FormattingEnabled = true;
            this.cboxStaff.Location = new System.Drawing.Point(505, 167);
            this.cboxStaff.Name = "cboxStaff";
            this.cboxStaff.Size = new System.Drawing.Size(121, 21);
            this.cboxStaff.TabIndex = 32;
            // 
            // FormIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 411);
            this.Controls.Add(this.lblSatff);
            this.Controls.Add(this.cboxStaff);
            this.Controls.Add(this.lblCub);
            this.Controls.Add(this.cboxCub);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cboxDept);
            this.Controls.Add(this.cboxRoomNo);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEnterItemName);
            this.Controls.Add(this.lblSelectMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxMH);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboxItem);
            this.Name = "FormIssue";
            this.Text = "Form Issue";
            this.Load += new System.EventHandler(this.FormIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelectMH;
        private System.Windows.Forms.Label lblEnterItemName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxIssueTo;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cboxDept;
        private System.Windows.Forms.ComboBox cboxRoomNo;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblCub;
        private System.Windows.Forms.ComboBox cboxCub;
        private System.Windows.Forms.Label lblSatff;
        private System.Windows.Forms.ComboBox cboxStaff;
    }
}