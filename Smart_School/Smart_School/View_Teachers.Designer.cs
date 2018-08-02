namespace Smart_School
{
    partial class View_Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Teachers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVHTAddress = new System.Windows.Forms.Label();
            this.lblVHTEmail = new System.Windows.Forms.Label();
            this.lblVHTPhone = new System.Windows.Forms.Label();
            this.lblVHTJoinDate = new System.Windows.Forms.Label();
            this.lblVHTQualification = new System.Windows.Forms.Label();
            this.lblVHTName = new System.Windows.Forms.Label();
            this.pictureBoxVHTeacher = new System.Windows.Forms.PictureBox();
            this.dataGridViewATeachers_Info = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVHTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATeachers_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblVHTAddress);
            this.panel1.Controls.Add(this.lblVHTEmail);
            this.panel1.Controls.Add(this.lblVHTPhone);
            this.panel1.Controls.Add(this.lblVHTJoinDate);
            this.panel1.Controls.Add(this.lblVHTQualification);
            this.panel1.Controls.Add(this.lblVHTName);
            this.panel1.Controls.Add(this.pictureBoxVHTeacher);
            this.panel1.Location = new System.Drawing.Point(72, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 163);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblVHTAddress
            // 
            this.lblVHTAddress.AutoSize = true;
            this.lblVHTAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVHTAddress.Location = new System.Drawing.Point(200, 126);
            this.lblVHTAddress.Name = "lblVHTAddress";
            this.lblVHTAddress.Size = new System.Drawing.Size(51, 15);
            this.lblVHTAddress.TabIndex = 6;
            this.lblVHTAddress.Text = "Address";
            // 
            // lblVHTEmail
            // 
            this.lblVHTEmail.AutoSize = true;
            this.lblVHTEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVHTEmail.Location = new System.Drawing.Point(200, 100);
            this.lblVHTEmail.Name = "lblVHTEmail";
            this.lblVHTEmail.Size = new System.Drawing.Size(39, 15);
            this.lblVHTEmail.TabIndex = 5;
            this.lblVHTEmail.Text = "Email";
            // 
            // lblVHTPhone
            // 
            this.lblVHTPhone.AutoSize = true;
            this.lblVHTPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVHTPhone.Location = new System.Drawing.Point(200, 85);
            this.lblVHTPhone.Name = "lblVHTPhone";
            this.lblVHTPhone.Size = new System.Drawing.Size(43, 15);
            this.lblVHTPhone.TabIndex = 4;
            this.lblVHTPhone.Text = "Phone";
            // 
            // lblVHTJoinDate
            // 
            this.lblVHTJoinDate.AutoSize = true;
            this.lblVHTJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVHTJoinDate.Location = new System.Drawing.Point(200, 63);
            this.lblVHTJoinDate.Name = "lblVHTJoinDate";
            this.lblVHTJoinDate.Size = new System.Drawing.Size(72, 15);
            this.lblVHTJoinDate.TabIndex = 3;
            this.lblVHTJoinDate.Text = "Date of Join";
            // 
            // lblVHTQualification
            // 
            this.lblVHTQualification.AutoSize = true;
            this.lblVHTQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVHTQualification.Location = new System.Drawing.Point(200, 48);
            this.lblVHTQualification.Name = "lblVHTQualification";
            this.lblVHTQualification.Size = new System.Drawing.Size(75, 15);
            this.lblVHTQualification.TabIndex = 2;
            this.lblVHTQualification.Text = "Qualification";
            // 
            // lblVHTName
            // 
            this.lblVHTName.AutoSize = true;
            this.lblVHTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVHTName.Location = new System.Drawing.Point(200, 15);
            this.lblVHTName.Name = "lblVHTName";
            this.lblVHTName.Size = new System.Drawing.Size(49, 16);
            this.lblVHTName.TabIndex = 1;
            this.lblVHTName.Text = "Name";
            // 
            // pictureBoxVHTeacher
            // 
            this.pictureBoxVHTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVHTeacher.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVHTeacher.Image")));
            this.pictureBoxVHTeacher.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxVHTeacher.Name = "pictureBoxVHTeacher";
            this.pictureBoxVHTeacher.Size = new System.Drawing.Size(151, 157);
            this.pictureBoxVHTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVHTeacher.TabIndex = 0;
            this.pictureBoxVHTeacher.TabStop = false;
            // 
            // dataGridViewATeachers_Info
            // 
            this.dataGridViewATeachers_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewATeachers_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewATeachers_Info.Location = new System.Drawing.Point(12, 203);
            this.dataGridViewATeachers_Info.Name = "dataGridViewATeachers_Info";
            this.dataGridViewATeachers_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewATeachers_Info.Size = new System.Drawing.Size(593, 150);
            this.dataGridViewATeachers_Info.TabIndex = 1;
            this.dataGridViewATeachers_Info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewATeachers_Info_CellClick);
            // 
            // View_Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 365);
            this.Controls.Add(this.dataGridViewATeachers_Info);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Teachers";
            this.Text = "View Teachers";
            this.Load += new System.EventHandler(this.View_Teachers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVHTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATeachers_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewATeachers_Info;
        private System.Windows.Forms.Label lblVHTName;
        private System.Windows.Forms.PictureBox pictureBoxVHTeacher;
        private System.Windows.Forms.Label lblVHTAddress;
        private System.Windows.Forms.Label lblVHTEmail;
        private System.Windows.Forms.Label lblVHTPhone;
        private System.Windows.Forms.Label lblVHTJoinDate;
        private System.Windows.Forms.Label lblVHTQualification;
    }
}