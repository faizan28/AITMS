namespace AIT_MS
{
    partial class addhead
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.masterHeadBox = new System.Windows.Forms.ComboBox();
            this.headBox = new System.Windows.Forms.TextBox();
            this.lblEnterHead = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnterHead);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.masterHeadBox);
            this.groupBox1.Controls.Add(this.headBox);
            this.groupBox1.Location = new System.Drawing.Point(78, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Head";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(333, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(237, 189);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter New Head Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Master Head";
            // 
            // masterHeadBox
            // 
            this.masterHeadBox.FormattingEnabled = true;
            this.masterHeadBox.Location = new System.Drawing.Point(191, 47);
            this.masterHeadBox.Name = "masterHeadBox";
            this.masterHeadBox.Size = new System.Drawing.Size(231, 21);
            this.masterHeadBox.TabIndex = 1;
            // 
            // headBox
            // 
            this.headBox.Location = new System.Drawing.Point(191, 107);
            this.headBox.Name = "headBox";
            this.headBox.Size = new System.Drawing.Size(231, 20);
            this.headBox.TabIndex = 0;
            this.headBox.TextChanged += new System.EventHandler(this.headBox_TextChanged);
            // 
            // lblEnterHead
            // 
            this.lblEnterHead.AutoSize = true;
            this.lblEnterHead.ForeColor = System.Drawing.Color.Red;
            this.lblEnterHead.Location = new System.Drawing.Point(330, 130);
            this.lblEnterHead.Name = "lblEnterHead";
            this.lblEnterHead.Size = new System.Drawing.Size(92, 13);
            this.lblEnterHead.TabIndex = 6;
            this.lblEnterHead.Text = "Enter Head Name";
            // 
            // addhead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 372);
            this.Controls.Add(this.groupBox1);
            this.Name = "addhead";
            this.Text = "Create New Head";
            this.Load += new System.EventHandler(this.addhead_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox masterHeadBox;
        private System.Windows.Forms.TextBox headBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label lblEnterHead;
    }
}