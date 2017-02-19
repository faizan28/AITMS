namespace AIT_MS
{
    partial class NewWirteOff
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
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.Label();
            this.txtUseriD = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtrboxRemarks = new System.Windows.Forms.RichTextBox();
            this.lblSatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblSatff = new System.Windows.Forms.Label();
            this.cboxStaff = new System.Windows.Forms.ComboBox();
            this.lblCub = new System.Windows.Forms.Label();
            this.cboxCub = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cboxDept = new System.Windows.Forms.ComboBox();
            this.cboxRoomNo = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxWriteoffTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteRow.Location = new System.Drawing.Point(719, 171);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(55, 26);
            this.btnDeleteRow.TabIndex = 71;
            this.btnDeleteRow.Text = "Delete";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIssue.ForeColor = System.Drawing.Color.Black;
            this.btnIssue.Location = new System.Drawing.Point(554, 171);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(63, 26);
            this.btnIssue.TabIndex = 70;
            this.btnIssue.Text = "WriteOff";
            this.btnIssue.UseVisualStyleBackColor = false;
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(274, 115);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(43, 13);
            this.userid.TabIndex = 69;
            this.userid.Text = "User ID";
            // 
            // txtUseriD
            // 
            this.txtUseriD.Location = new System.Drawing.Point(369, 112);
            this.txtUseriD.Name = "txtUseriD";
            this.txtUseriD.Size = new System.Drawing.Size(121, 20);
            this.txtUseriD.TabIndex = 68;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(506, 45);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 67;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtrboxRemarks
            // 
            this.txtrboxRemarks.Location = new System.Drawing.Point(573, 42);
            this.txtrboxRemarks.Name = "txtrboxRemarks";
            this.txtrboxRemarks.Size = new System.Drawing.Size(186, 109);
            this.txtrboxRemarks.TabIndex = 66;
            this.txtrboxRemarks.Text = "";
            // 
            // lblSatus
            // 
            this.lblSatus.AutoSize = true;
            this.lblSatus.Location = new System.Drawing.Point(506, 14);
            this.lblSatus.Name = "lblSatus";
            this.lblSatus.Size = new System.Drawing.Size(37, 13);
            this.lblSatus.TabIndex = 65;
            this.lblSatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(573, 11);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(186, 21);
            this.cmbStatus.TabIndex = 64;
            // 
            // lblSatff
            // 
            this.lblSatff.AutoSize = true;
            this.lblSatff.Location = new System.Drawing.Point(37, 188);
            this.lblSatff.Name = "lblSatff";
            this.lblSatff.Size = new System.Drawing.Size(29, 13);
            this.lblSatff.TabIndex = 63;
            this.lblSatff.Text = "Staff";
            // 
            // cboxStaff
            // 
            this.cboxStaff.FormattingEnabled = true;
            this.cboxStaff.Location = new System.Drawing.Point(113, 185);
            this.cboxStaff.Name = "cboxStaff";
            this.cboxStaff.Size = new System.Drawing.Size(121, 21);
            this.cboxStaff.TabIndex = 62;
            this.cboxStaff.SelectedIndexChanged += new System.EventHandler(this.cboxStaff_SelectedIndexChanged);
            // 
            // lblCub
            // 
            this.lblCub.AutoSize = true;
            this.lblCub.Location = new System.Drawing.Point(37, 160);
            this.lblCub.Name = "lblCub";
            this.lblCub.Size = new System.Drawing.Size(59, 13);
            this.lblCub.TabIndex = 61;
            this.lblCub.Text = "Cubicle No";
            // 
            // cboxCub
            // 
            this.cboxCub.FormattingEnabled = true;
            this.cboxCub.Location = new System.Drawing.Point(113, 157);
            this.cboxCub.Name = "cboxCub";
            this.cboxCub.Size = new System.Drawing.Size(121, 21);
            this.cboxCub.TabIndex = 60;
            this.cboxCub.SelectedIndexChanged += new System.EventHandler(this.cboxCub_SelectedIndexChanged);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(37, 106);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 59;
            this.lblDept.Text = "Department";
            // 
            // cboxDept
            // 
            this.cboxDept.FormattingEnabled = true;
            this.cboxDept.Location = new System.Drawing.Point(113, 103);
            this.cboxDept.Name = "cboxDept";
            this.cboxDept.Size = new System.Drawing.Size(121, 21);
            this.cboxDept.TabIndex = 58;
            this.cboxDept.SelectedIndexChanged += new System.EventHandler(this.cboxDept_SelectedIndexChanged_1);
            // 
            // cboxRoomNo
            // 
            this.cboxRoomNo.FormattingEnabled = true;
            this.cboxRoomNo.Location = new System.Drawing.Point(113, 130);
            this.cboxRoomNo.Name = "cboxRoomNo";
            this.cboxRoomNo.Size = new System.Drawing.Size(121, 21);
            this.cboxRoomNo.TabIndex = 57;
            this.cboxRoomNo.SelectedIndexChanged += new System.EventHandler(this.cboxRoomNo_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(37, 133);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(52, 13);
            this.lblRoom.TabIndex = 56;
            this.lblRoom.Text = "Room No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxWriteoffTo);
            this.groupBox1.Location = new System.Drawing.Point(40, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WriteOff To";
            // 
            // cboxWriteoffTo
            // 
            this.cboxWriteoffTo.FormattingEnabled = true;
            this.cboxWriteoffTo.Location = new System.Drawing.Point(6, 15);
            this.cboxWriteoffTo.Name = "cboxWriteoffTo";
            this.cboxWriteoffTo.Size = new System.Drawing.Size(188, 21);
            this.cboxWriteoffTo.TabIndex = 26;
            this.cboxWriteoffTo.SelectedIndexChanged += new System.EventHandler(this.cboxWriteoffTo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(40, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Issued Item";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(369, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(369, 86);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(121, 20);
            this.txtQty.TabIndex = 43;
            // 
            // cboxItem
            // 
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(369, 59);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(121, 21);
            this.cboxItem.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 202);
            this.dataGridView1.TabIndex = 72;
            // 
            // NewWirteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.txtUseriD);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtrboxRemarks);
            this.Controls.Add(this.lblSatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblSatff);
            this.Controls.Add(this.cboxStaff);
            this.Controls.Add(this.lblCub);
            this.Controls.Add(this.cboxCub);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cboxDept);
            this.Controls.Add(this.cboxRoomNo);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cboxItem);
            this.Name = "NewWirteOff";
            this.Text = "NewWirteOff";
            this.Load += new System.EventHandler(this.NewWirteOff_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.TextBox txtUseriD;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.RichTextBox txtrboxRemarks;
        private System.Windows.Forms.Label lblSatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblSatff;
        private System.Windows.Forms.ComboBox cboxStaff;
        private System.Windows.Forms.Label lblCub;
        private System.Windows.Forms.ComboBox cboxCub;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cboxDept;
        private System.Windows.Forms.ComboBox cboxRoomNo;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxWriteoffTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}