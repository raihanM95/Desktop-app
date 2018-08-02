namespace Smart_School
{
    partial class View_Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Students));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtVSSearch = new System.Windows.Forms.TextBox();
            this.btnVSSearch = new System.Windows.Forms.Button();
            this.dataGridViewStudents_Info = new System.Windows.Forms.DataGridView();
            this.pnlVSUpdate = new System.Windows.Forms.Panel();
            this.txtVSUPic = new System.Windows.Forms.TextBox();
            this.btnVSUPBrowse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtVSUAddress = new System.Windows.Forms.TextBox();
            this.txtVSUEmail = new System.Windows.Forms.TextBox();
            this.txtVSURoll = new System.Windows.Forms.TextBox();
            this.cmbVSUClass = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVSUA = new System.Windows.Forms.DateTimePicker();
            this.txtVSUMName = new System.Windows.Forms.TextBox();
            this.txtVSUFName = new System.Windows.Forms.TextBox();
            this.cmbVSUGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVSUB = new System.Windows.Forms.DateTimePicker();
            this.txtVSUName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents_Info)).BeginInit();
            this.pnlVSUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtVSSearch);
            this.panel1.Controls.Add(this.btnVSSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 26);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txtVSSearch
            // 
            this.txtVSSearch.Location = new System.Drawing.Point(32, 3);
            this.txtVSSearch.Name = "txtVSSearch";
            this.txtVSSearch.Size = new System.Drawing.Size(266, 20);
            this.txtVSSearch.TabIndex = 5;
            this.txtVSSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVSSearch_KeyUp);
            // 
            // btnVSSearch
            // 
            this.btnVSSearch.Location = new System.Drawing.Point(304, 1);
            this.btnVSSearch.Name = "btnVSSearch";
            this.btnVSSearch.Size = new System.Drawing.Size(75, 23);
            this.btnVSSearch.TabIndex = 4;
            this.btnVSSearch.Text = "Search";
            this.btnVSSearch.UseVisualStyleBackColor = true;
            this.btnVSSearch.Click += new System.EventHandler(this.btnVSSearch_Click);
            // 
            // dataGridViewStudents_Info
            // 
            this.dataGridViewStudents_Info.AllowUserToOrderColumns = true;
            this.dataGridViewStudents_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudents_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewStudents_Info.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewStudents_Info.Name = "dataGridViewStudents_Info";
            this.dataGridViewStudents_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents_Info.Size = new System.Drawing.Size(799, 123);
            this.dataGridViewStudents_Info.TabIndex = 6;
            this.dataGridViewStudents_Info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_Info_CellClick);
            // 
            // pnlVSUpdate
            // 
            this.pnlVSUpdate.Controls.Add(this.txtVSUPic);
            this.pnlVSUpdate.Controls.Add(this.btnVSUPBrowse);
            this.pnlVSUpdate.Controls.Add(this.btnUpdate);
            this.pnlVSUpdate.Controls.Add(this.txtVSUAddress);
            this.pnlVSUpdate.Controls.Add(this.txtVSUEmail);
            this.pnlVSUpdate.Controls.Add(this.txtVSURoll);
            this.pnlVSUpdate.Controls.Add(this.cmbVSUClass);
            this.pnlVSUpdate.Controls.Add(this.dateTimePickerVSUA);
            this.pnlVSUpdate.Controls.Add(this.txtVSUMName);
            this.pnlVSUpdate.Controls.Add(this.txtVSUFName);
            this.pnlVSUpdate.Controls.Add(this.cmbVSUGender);
            this.pnlVSUpdate.Controls.Add(this.dateTimePickerVSUB);
            this.pnlVSUpdate.Controls.Add(this.txtVSUName);
            this.pnlVSUpdate.Controls.Add(this.label10);
            this.pnlVSUpdate.Controls.Add(this.label9);
            this.pnlVSUpdate.Controls.Add(this.label8);
            this.pnlVSUpdate.Controls.Add(this.label7);
            this.pnlVSUpdate.Controls.Add(this.label6);
            this.pnlVSUpdate.Controls.Add(this.label5);
            this.pnlVSUpdate.Controls.Add(this.label4);
            this.pnlVSUpdate.Controls.Add(this.label3);
            this.pnlVSUpdate.Controls.Add(this.label2);
            this.pnlVSUpdate.Controls.Add(this.label1);
            this.pnlVSUpdate.Location = new System.Drawing.Point(12, 183);
            this.pnlVSUpdate.Name = "pnlVSUpdate";
            this.pnlVSUpdate.Size = new System.Drawing.Size(799, 207);
            this.pnlVSUpdate.TabIndex = 8;
            this.pnlVSUpdate.Visible = false;
            // 
            // txtVSUPic
            // 
            this.txtVSUPic.Enabled = false;
            this.txtVSUPic.Location = new System.Drawing.Point(572, 124);
            this.txtVSUPic.Name = "txtVSUPic";
            this.txtVSUPic.Size = new System.Drawing.Size(177, 20);
            this.txtVSUPic.TabIndex = 46;
            // 
            // btnVSUPBrowse
            // 
            this.btnVSUPBrowse.Location = new System.Drawing.Point(497, 122);
            this.btnVSUPBrowse.Name = "btnVSUPBrowse";
            this.btnVSUPBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnVSUPBrowse.TabIndex = 45;
            this.btnVSUPBrowse.Text = "Browse";
            this.btnVSUPBrowse.UseVisualStyleBackColor = true;
            this.btnVSUPBrowse.Click += new System.EventHandler(this.btnVSUPBrowse_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtVSUAddress
            // 
            this.txtVSUAddress.Location = new System.Drawing.Point(92, 113);
            this.txtVSUAddress.Multiline = true;
            this.txtVSUAddress.Name = "txtVSUAddress";
            this.txtVSUAddress.Size = new System.Drawing.Size(291, 34);
            this.txtVSUAddress.TabIndex = 43;
            // 
            // txtVSUEmail
            // 
            this.txtVSUEmail.Location = new System.Drawing.Point(497, 80);
            this.txtVSUEmail.Name = "txtVSUEmail";
            this.txtVSUEmail.Size = new System.Drawing.Size(291, 20);
            this.txtVSUEmail.TabIndex = 42;
            // 
            // txtVSURoll
            // 
            this.txtVSURoll.Location = new System.Drawing.Point(747, 51);
            this.txtVSURoll.Name = "txtVSURoll";
            this.txtVSURoll.Size = new System.Drawing.Size(41, 20);
            this.txtVSURoll.TabIndex = 41;
            // 
            // cmbVSUClass
            // 
            this.cmbVSUClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVSUClass.FormattingEnabled = true;
            this.cmbVSUClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbVSUClass.Location = new System.Drawing.Point(611, 51);
            this.cmbVSUClass.Name = "cmbVSUClass";
            this.cmbVSUClass.Size = new System.Drawing.Size(53, 21);
            this.cmbVSUClass.TabIndex = 40;
            // 
            // dateTimePickerVSUA
            // 
            this.dateTimePickerVSUA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVSUA.Location = new System.Drawing.Point(706, 11);
            this.dateTimePickerVSUA.Name = "dateTimePickerVSUA";
            this.dateTimePickerVSUA.Size = new System.Drawing.Size(82, 20);
            this.dateTimePickerVSUA.TabIndex = 39;
            // 
            // txtVSUMName
            // 
            this.txtVSUMName.Location = new System.Drawing.Point(92, 80);
            this.txtVSUMName.Name = "txtVSUMName";
            this.txtVSUMName.Size = new System.Drawing.Size(291, 20);
            this.txtVSUMName.TabIndex = 38;
            // 
            // txtVSUFName
            // 
            this.txtVSUFName.Location = new System.Drawing.Point(92, 46);
            this.txtVSUFName.Name = "txtVSUFName";
            this.txtVSUFName.Size = new System.Drawing.Size(291, 20);
            this.txtVSUFName.TabIndex = 37;
            // 
            // cmbVSUGender
            // 
            this.cmbVSUGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVSUGender.FormattingEnabled = true;
            this.cmbVSUGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbVSUGender.Location = new System.Drawing.Point(497, 51);
            this.cmbVSUGender.Name = "cmbVSUGender";
            this.cmbVSUGender.Size = new System.Drawing.Size(53, 21);
            this.cmbVSUGender.TabIndex = 36;
            // 
            // dateTimePickerVSUB
            // 
            this.dateTimePickerVSUB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVSUB.Location = new System.Drawing.Point(497, 11);
            this.dateTimePickerVSUB.Name = "dateTimePickerVSUB";
            this.dateTimePickerVSUB.Size = new System.Drawing.Size(82, 20);
            this.dateTimePickerVSUB.TabIndex = 35;
            this.dateTimePickerVSUB.Value = new System.DateTime(2017, 8, 30, 19, 52, 17, 0);
            // 
            // txtVSUName
            // 
            this.txtVSUName.Location = new System.Drawing.Point(92, 11);
            this.txtVSUName.Name = "txtVSUName";
            this.txtVSUName.Size = new System.Drawing.Size(291, 20);
            this.txtVSUName.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Date of Admission";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Class Roll No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mother\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Father\'s Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // View_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 402);
            this.Controls.Add(this.pnlVSUpdate);
            this.Controls.Add(this.dataGridViewStudents_Info);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Students";
            this.Text = "View Students";
            this.Load += new System.EventHandler(this.View_Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents_Info)).EndInit();
            this.pnlVSUpdate.ResumeLayout(false);
            this.pnlVSUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVSSearch;
        private System.Windows.Forms.TextBox txtVSSearch;
        private System.Windows.Forms.Panel pnlVSUpdate;
        private System.Windows.Forms.TextBox txtVSUAddress;
        private System.Windows.Forms.TextBox txtVSUEmail;
        private System.Windows.Forms.TextBox txtVSURoll;
        private System.Windows.Forms.ComboBox cmbVSUClass;
        private System.Windows.Forms.DateTimePicker dateTimePickerVSUA;
        private System.Windows.Forms.TextBox txtVSUMName;
        private System.Windows.Forms.TextBox txtVSUFName;
        private System.Windows.Forms.ComboBox cmbVSUGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerVSUB;
        private System.Windows.Forms.TextBox txtVSUName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewStudents_Info;
        private System.Windows.Forms.Button btnVSUPBrowse;
        private System.Windows.Forms.TextBox txtVSUPic;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}