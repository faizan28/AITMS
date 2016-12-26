namespace AIT_MS.Register
{
    partial class CreateCub
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
            this.cboxRoomNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCubicalName = new System.Windows.Forms.TextBox();
            this.createcubButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxRoomNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCubicalName);
            this.groupBox1.Location = new System.Drawing.Point(39, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration of Cubicle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxRoomNo
            // 
            this.cboxRoomNo.FormattingEnabled = true;
            this.cboxRoomNo.Location = new System.Drawing.Point(252, 61);
            this.cboxRoomNo.Name = "cboxRoomNo";
            this.cboxRoomNo.Size = new System.Drawing.Size(121, 21);
            this.cboxRoomNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cubicle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCubicalName
            // 
            this.txtCubicalName.Location = new System.Drawing.Point(252, 102);
            this.txtCubicalName.Name = "txtCubicalName";
            this.txtCubicalName.Size = new System.Drawing.Size(121, 20);
            this.txtCubicalName.TabIndex = 1;
            // 
            // createcubButton
            // 
            this.createcubButton.Location = new System.Drawing.Point(316, 287);
            this.createcubButton.Name = "createcubButton";
            this.createcubButton.Size = new System.Drawing.Size(75, 23);
            this.createcubButton.TabIndex = 4;
            this.createcubButton.Text = "Create";
            this.createcubButton.UseVisualStyleBackColor = true;
            this.createcubButton.Click += new System.EventHandler(this.createcubButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(408, 287);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateCub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 338);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createcubButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateCub";
            this.Text = "CreateCub";
            this.Load += new System.EventHandler(this.CreateCub_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCubicalName;
        private System.Windows.Forms.Button createcubButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox cboxRoomNo;
    }
}